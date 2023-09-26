using ActiveSmartWeb.MetodosPago.Entidades;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Authorize
{
    public abstract class PagoAuthorize
    {
        //Credenciales de prueba
        //private static string ApiLoginID = "5dP8ESWyp97";
        //private static string ApiTransactionKey = "87Mr8AAKc3g3s493";


        //Credenciales de produccion
        private static string ApiLoginID = "638MVB6ps3Eb";
        private static string ApiTransactionKey = "77M2DrM4HvyP74zj";

        public static EResultadoSuscripcion crearSubscripcion(short intervalLength, decimal amount, string numerotarjeta, string fechaVencimiento, string codigo, string nombretitular, string apellidotitular)
        {

            //Ambiente de pruebas
            //ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            //Ambiente de produccion
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey,
            };

            paymentScheduleTypeInterval interval = new paymentScheduleTypeInterval();

            interval.length = intervalLength;                        // months can be indicated between 1 and 12
            interval.unit = ARBSubscriptionUnitEnum.months;

            paymentScheduleType schedule = new paymentScheduleType
            {
                interval = interval,
                startDate = DateTime.Now.AddDays(1),      // start date should be tomorrow
                totalOccurrences = 9999,                          // 999 indicates no end date
                trialOccurrences = 0
            };

            #region Payment Information
            var creditCard = new creditCardType
            {
                cardNumber = numerotarjeta.Replace(" ", ""), //"4111111111111111"
                expirationDate = fechaVencimiento.Replace("/", ""),//"1028",
                cardCode = codigo //"123"
            };

            //standard api call to retrieve response
            paymentType cc = new paymentType { Item = creditCard };
            #endregion

            nameAndAddressType addressInfo = new nameAndAddressType()
            {
                firstName = nombretitular,
                lastName = apellidotitular
            };

            ARBSubscriptionType subscriptionType = new ARBSubscriptionType()
            {
                amount = 1.00M,
                trialAmount = 0.00m,
                paymentSchedule = schedule,
                billTo = addressInfo,
                payment = cc
            };

            var request = new ARBCreateSubscriptionRequest { subscription = subscriptionType };

            var controller = new ARBCreateSubscriptionController(request);          // instantiate the controller that will call the service
            controller.Execute();

            ARBCreateSubscriptionResponse response = controller.GetApiResponse();   // get the response from the service (errors contained if any)

            EResultadoSuscripcion resultado = new EResultadoSuscripcion();
            //validate response
            if (response != null && response.messages.resultCode == messageTypeEnum.Ok)
            {
                if (response != null && response.messages.message != null)
                {
                    resultado.Resultado = "Success";
                    resultado.SuscripcionId = response.subscriptionId;
                    resultado.IdCustomerProfile = response.profile.customerProfileId;
                    resultado.IdPaymentProfile = response.profile.customerPaymentProfileId;
                    resultado.AdressId = response.profile.customerAddressId == null ? "No tiene" : response.profile.customerAddressId;
                    resultado.RefId = response.refId == null ? "No tiene" : response.refId;
                    return resultado;
                }
            }
            else if (response != null)
            {

                resultado.Resultado = "Error";
                return resultado;
            }


            resultado.Resultado = "Error";
            return resultado;
        }

        //Obtiene el estatus actual de una suscripcion
        public static string getStatus(string subscriptionId)
        {

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey,
            };

            //please update the subscriptionId according to your sandbox credentials
            var request = new ARBGetSubscriptionStatusRequest { subscriptionId = subscriptionId };

            var controller = new ARBGetSubscriptionStatusController(request);                          // instantiate the controller that will call the service
            controller.Execute();

            ARBGetSubscriptionStatusResponse response = controller.GetApiResponse();                   // get the response from the service (errors contained if any)

            // validate response
            if (response != null && response.messages.resultCode == messageTypeEnum.Ok)
            {
                if (response != null && response.messages.message != null)
                {
                    return response.status.ToString();
                }
            }

            return "No existe";
        }


        private string realizarTransaccion(decimal amount, string numerotarjeta, string fechaVencimiento, string codigo, string nombretitular, string pais, string ciudad, string direccion)
        {

            Console.WriteLine("Charge Credit Card Sample");

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            // define the merchant information (authentication / transaction id)
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey,
            };

            var creditCard = new creditCardType
            {
                cardNumber = numerotarjeta.Replace(" ", ""), //"4111111111111111"
                expirationDate = fechaVencimiento.Replace("/", ""),//"1028",
                cardCode = codigo //"123"
            };

            var billingAddress = new customerAddressType
            {
                firstName = nombretitular, //"John",
                address = direccion, //"123 My St",
                city = ciudad, //"OurTown",
                country = pais
                //zip = "98004"
            };

            //standard api call to retrieve response
            var paymentType = new paymentType { Item = creditCard };

            // Add line Items
            var lineItems = new lineItemType[2];
            lineItems[0] = new lineItemType { itemId = "1", name = "Activos", quantity = 1, unitPrice = new Decimal(1.00) };
            lineItems[1] = new lineItemType { itemId = "2", name = "snowboard", quantity = 1, unitPrice = new Decimal(2.00) };

            var transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),    // charge the card

                amount = amount,
                payment = paymentType,
                billTo = billingAddress,
                lineItems = lineItems
            };

            var request = new createTransactionRequest { transactionRequest = transactionRequest };

            // instantiate the controller that will call the service
            var controller = new createTransactionController(request);
            controller.Execute();

            // get the response from the service (errors contained if any)
            var response = controller.GetApiResponse();

            // validate response
            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    if (response.transactionResponse.messages != null)
                    {

                        return "Transacción realizada correctamente";

                    }
                    else
                    {
                        return "No se pudo realizar la transacción, por favor revise sus datos";
                    }
                }
                else
                {
                    return "No se pudo realizar la transacción, por favor revise sus datos";
                }
            }
            else
            {
                return "No se pudo realizar la transacción, por favor revise sus datos";
            }

        }


        public static EMetodoPago ObtenerInformacionPerfilPago(string customerProfileId, EPerfilPago customerPaymentProfileId)
        {


            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;
            // define the merchant information (authentication / transaction id)
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey,
            };

            var request = new getCustomerPaymentProfileRequest();
            request.customerProfileId = customerProfileId;
            request.customerPaymentProfileId = customerPaymentProfileId.IdPerfilPago;

            // Set this optional property to true to return an unmasked expiration date
            request.unmaskExpirationDateSpecified = true;
            request.unmaskExpirationDate = true;


            // instantiate the controller that will call the service
            var controller = new getCustomerPaymentProfileController(request);
            controller.Execute();

            // get the response from the service (errors contained if any)
            var response = controller.GetApiResponse();

            if (response != null && response.messages.resultCode == messageTypeEnum.Ok)
            {
 
                if (response.paymentProfile.payment.Item is creditCardMaskedType)
                {

                    if (response.paymentProfile.subscriptionIds != null && response.paymentProfile.subscriptionIds.Length > 0)
                    {
                        return new EMetodoPago(
                            customerPaymentProfileId.Id,
                            customerPaymentProfileId.IdPerfilPago,
                            (response.paymentProfile.payment.Item as creditCardMaskedType).cardNumber,
                            (response.paymentProfile.payment.Item as creditCardMaskedType).expirationDate,
                            (response.paymentProfile.payment.Item as creditCardMaskedType).cardType,
                            response.paymentProfile.billTo.firstName,
                            response.paymentProfile.billTo.lastName,
                            customerPaymentProfileId.Predeterminado
                            );
                    }
                }
            }

            return null;
        }


        public static decimal ObtenerSuscripcionMonto(string subscriptionId)
        {


            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey
            };

            var request = new ARBGetSubscriptionRequest { subscriptionId = subscriptionId };

            var controller = new ARBGetSubscriptionController(request);          // instantiate the controller that will call the service
            controller.Execute();

            ARBGetSubscriptionResponse response = controller.GetApiResponse();   // get the response from the service (errors contained if any)
            decimal monto = response.subscription.amount;
            // validate response
            if (response != null && response.messages.resultCode == messageTypeEnum.Ok)
            {
                if (response.subscription != null)
                {
                    Console.WriteLine("Subscription returned : " + response.subscription.name);
                }
            }
            else if (response != null)
            {
                if (response.messages.message.Length > 0)
                {
                    Console.WriteLine("Error: " + response.messages.message[0].code + "  " +
                                      response.messages.message[0].text);
                }
            }
            else
            {
                if (controller.GetErrorResponse().messages.message.Length > 0)
                {
                    Console.WriteLine("Error: " + response.messages.message[0].code + "  " + response.messages.message[0].text);
                }
            }

            return monto;
        }

        public static ANetApiResponse ProcesarPagoTienda( string customerProfileId,string customerPaymentProfileId, decimal Amount)
        {

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;

            // define the merchant information (authentication / transaction id)
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = ApiLoginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = ApiTransactionKey
            };

            //create a customer payment profile
            customerProfilePaymentType profileToCharge = new customerProfilePaymentType();
            profileToCharge.customerProfileId = customerProfileId;
            profileToCharge.paymentProfile = new paymentProfile { paymentProfileId = customerPaymentProfileId };

            var transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),    // refund type
                amount = Amount,
                profile = profileToCharge
            };

            var request = new createTransactionRequest { transactionRequest = transactionRequest };

            // instantiate the collector that will call the service
            var controller = new createTransactionController(request);
            controller.Execute();

            // get the response from the service (errors contained if any)
            var response = controller.GetApiResponse();

            // validate response
            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    if (response.transactionResponse.messages != null)
                    {
                        Console.WriteLine("Successfully created transaction with Transaction ID: " + response.transactionResponse.transId);
                        Console.WriteLine("Response Code: " + response.transactionResponse.responseCode);
                        Console.WriteLine("Message Code: " + response.transactionResponse.messages[0].code);
                        Console.WriteLine("Description: " + response.transactionResponse.messages[0].description);
                        Console.WriteLine("Success, Auth Code : " + response.transactionResponse.authCode);
                    }
                    else
                    {
                        Console.WriteLine("Failed Transaction.");
                        if (response.transactionResponse.errors != null)
                        {
                            Console.WriteLine("Error Code: " + response.transactionResponse.errors[0].errorCode);
                            Console.WriteLine("Error message: " + response.transactionResponse.errors[0].errorText);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failed Transaction.");
                    if (response.transactionResponse != null && response.transactionResponse.errors != null)
                    {
                        Console.WriteLine("Error Code: " + response.transactionResponse.errors[0].errorCode);
                        Console.WriteLine("Error message: " + response.transactionResponse.errors[0].errorText);
                    }
                    else
                    {
                        Console.WriteLine("Error Code: " + response.messages.message[0].code);
                        Console.WriteLine("Error message: " + response.messages.message[0].text);
                    }
                }
            }
            else
            {
                Console.WriteLine("Null Response.");
            }

            return response;
        }


    }
}
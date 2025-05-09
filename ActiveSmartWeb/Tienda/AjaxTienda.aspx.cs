﻿using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using ActiveSmartWeb.Tienda.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Authorize;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using ActiveSmartWeb.MetodosPago.Entidades;

namespace ActiveSmartWeb.Tienda
{
    public partial class AjaxTienda : System.Web.UI.Page
    {
        NMetodosPago nMetodos = new NMetodosPago();
        NUsuarioEmpresa nUsuarioEmpresa = new NUsuarioEmpresa();
        NTienda nTienda = new NTienda();
        private int numRegalia = 2;
        private int activosAdicionalesIlimitados = 2250;
        //Directorio de los paquetes adicionales seleccionados por el usuario para poder mostrarlos en la pantalla.
        private Dictionary<int, EPaqueteAdicional> _adicionalcontratadomostrar
        {
            get
            {
                var data = Session["Adicionalesmostrar"] as Dictionary<int, EPaqueteAdicional>;
                if (data == null)
                {
                    data = new Dictionary<int, EPaqueteAdicional>();
                    Session["Adicionalesmostrar"] = data;
                }
                return data;
            }
            set
            {
                Session["Adicionalesmostrar"] = value;
            }
        }
        

        //Directorio de los paquetes adicionales seleccionados por el usuario para poder mostrarlos en la pantalla.
        private Dictionary<int, EPaqueteAdicional> _adicionalPlanUsuario
        {
            get
            {
                var data = Session["AdicionalesPlanUsuario"] as Dictionary<int, EPaqueteAdicional>;
                if (data == null)
                {
                    data = new Dictionary<int, EPaqueteAdicional>();
                    Session["AdicionalesPlanUsuario"] = data;
                }
                return data;
            }
            set
            {
                Session["AdicionalesPlanUsuario"] = value;
            }
        }

        //Directorio de los paquetes adicionales seleccionados por el usuario para poder guardarlos en bd.
        private Dictionary<int, EPaqueteAdicionalContratado> _adicionalcontratado
        {
            get
            {
                var data = Session["Adicionales"] as Dictionary<int, EPaqueteAdicionalContratado>;
                if (data == null)
                {
                    data = new Dictionary<int, EPaqueteAdicionalContratado>();
                    Session["Adicionales"] = data;
                }
                return data;
            }
            set
            {
                Session["Adicionales"] = value;
            }
        }

        private void crearEntidades(int idAdicional, int cantidad, int cantidadpaquete, int cantidadpaqueteFree, string nombre, decimal costo, decimal costoMensual)
        {
            int cantidadRegalias = idAdicional == 1 ? 1 : numRegalia;
            //Crea los entidades de los adicionales una de ellas es para poder mostrarlos y la otra para guardarlos y se guardan los valores suministrados.
            EPaqueteAdicionalContratado adicionelesContratados = new EPaqueteAdicionalContratado();
            adicionelesContratados.IdPaqueteContratado = idAdicional;
            adicionelesContratados.Cantidad = cantidad;
            adicionelesContratados.CantidadRegalias = cantidadRegalias;

            EPaqueteAdicional adicionelesContratadosmostrar = new EPaqueteAdicional();
            adicionelesContratadosmostrar.IdPaqueteContratado = idAdicional;
            adicionelesContratadosmostrar.Cantidad = cantidadpaquete * cantidad;
            adicionelesContratadosmostrar.CantidadFree = cantidadpaqueteFree;
            adicionelesContratadosmostrar.Nombre = nombre;
            adicionelesContratadosmostrar.Descripcion = "";
            adicionelesContratadosmostrar.CantidadRegalias = cantidadRegalias;
            adicionelesContratadosmostrar.Costo = costo * cantidad;
            adicionelesContratadosmostrar.CostoMensual = costoMensual * cantidad;

            //Añade a los diccionarios las entidades anterirormente creadas.
            _adicionalcontratado.Add(idAdicional, (adicionelesContratados));
            _adicionalcontratadomostrar.Add(idAdicional, (adicionelesContratadosmostrar));
        }

        private void crearEntidadPlanUsuario(int idAdicional, int cantidad, int cantidadpaqueteFree, string nombre, decimal costo, decimal costoMensual, int cantidadRegalias)
        {

            EPaqueteAdicional adicional = new EPaqueteAdicional();
            adicional.IdPaqueteContratado = idAdicional;
            adicional.Cantidad =  cantidad;
            adicional.CantidadFree = cantidadpaqueteFree;
            adicional.Nombre = nombre;
            adicional.Descripcion = "";
            adicional.CantidadRegalias = cantidadRegalias;
            adicional.Costo = costo * cantidad;
            adicional.CostoMensual = costoMensual * cantidad;

            //Añade a los diccionarios las entidades anterirormente creadas.

            _adicionalPlanUsuario.Add(idAdicional, (adicional));
        }

        //Valida la cantidad de activos agregados para dar o retirar regalias
        private void validadRegalia(Boolean suma, int numActivos)
        {

            if (suma)
            {
                if (numActivos == 500 || numActivos == 1000 || numActivos == 1500 || numActivos == 2000)
                {
                    agregarRegalia();
                }
                else if (numActivos >= activosAdicionalesIlimitados)
                {
                    setCostoCero();
                }

            }
            else
            {
                if (numActivos == 250 || numActivos == 750 || numActivos == 1250 || numActivos == 1750)
                {
                    retirarRegalia();

                }
                else if (numActivos == 2000)
                {
                    recalcularCostos();
                }
            }
        }

        //Valida la cantidad de activos agregados mediante el input para dar o retirar regalias
        private void validarRegaliasInput(int numActivos)
        {
            int cantidadActualActivos = _adicionalcontratado[1].Cantidad;

            if (cantidadActualActivos < numActivos)
            {
                if (numActivos == 250)
                {
                    setRegalia(numRegalia);
                }
                else if (numActivos >= 500 && numActivos <= 750)
                {
                    setRegalia(numRegalia * 2);
                }
                else if (numActivos >= 1000 && numActivos <= 1250)
                {
                    setRegalia(numRegalia * 3);
                }
                else if (numActivos >= 1500 && numActivos <= 1750)
                {
                    setRegalia(numRegalia * 4);
                }
                else if (numActivos >= 2000)
                {
                    setRegalia(numRegalia * 5);
                }
            }
        }

        //Setea el numero de regalias
        private void setRegalia(int numRegalias)
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    int adicionalesContratados = _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad - _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias;

                    _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad = numRegalias + adicionalesContratados;
                    _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias = numRegalias;

                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad = numRegalias + adicionalesContratados;
                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias = numRegalias;
                }
            }
        }

        //Setea el costo de los adicionales en cero, menos los activos
        private void setCostoCero()
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Costo = 0;
                
                }
            }
        }

        //Recalcula los costos de los adicionales, menos los activos 
        private void recalcularCostos()
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    if (_adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias == _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad)
                    {
                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Costo = 0;

                    }
                    else
                    {
                        int cantidad =_adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias - _adicionalPlanUsuario[paquete.IdPaqueteContratado].Cantidad;

                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Costo = paquete.Costo * (cantidad);
                       
                    }
                }
            }
        }



        //Agrega regalias 
        private void agregarRegalia()
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad += numRegalia;
                    _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias += numRegalia;

                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad += numRegalia;
                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias += numRegalia;
                }
            }

        }

        //Retira regalias
        private void retirarRegalia()
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    if (_adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias >= (numRegalia * 2))
                    {
                        _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad -= numRegalia;
                        _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias -= numRegalia;

                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad -= numRegalia;
                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias -= numRegalia;
                    }

                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                switch (Request.Form["option"])
                {

                    //Opcion del switch para cargar los adicionales.
                    case "CargarAdicionales":
                        //Eliminamos el contenido de los diccionarios
                        _adicionalcontratado.Clear();
                        _adicionalcontratadomostrar.Clear();
                        //Traemos la informacion de los adicionales
                        var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

                        foreach (var paquete in ePaqueteAdicionales)
                        {
                            crearEntidades(
                            paquete.IdPaqueteContratado,
                            1,
                            paquete.Cantidad,
                            paquete.CantidadFree,
                            paquete.Nombre,
                            0,
                            0
                            );
                        }


                        Response.Write(JsonConvert.SerializeObject(ePaqueteAdicionales, Formatting.Indented));

                        break;

                    //Obtiene la informacion actual del plan del usuario
                    case "ObtenerPlanUsuario":
                        //Limpia la informacion del diccionario
                        _adicionalPlanUsuario.Clear();

                        int idUsuario = Convert.ToInt32(Request.Form["IdPerfilUsuario"]);

                        var planUsuario = nTienda.CargarAdicionales(idUsuario);

                        foreach (var paquete in planUsuario)
                        {

                            crearEntidadPlanUsuario(
                            paquete.IdPaqueteContratado,
                            paquete.Cantidad,
                            paquete.CantidadFree,
                            paquete.Nombre,
                            0,
                            0,
                            paquete.CantidadRegalias
                            );

                            _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad = paquete.Cantidad;
                            _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad = paquete.Cantidad;

                            _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias = paquete.Regalias;
                            _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias = paquete.Regalias;

                        }


                        Response.Write(JsonConvert.SerializeObject(_adicionalcontratadomostrar, Formatting.Indented));


                        break;

                    //Obtiene la frecuencia de pago del cliente
                    case "obtenerFrecuenciaPago":

                        Response.Write(nTienda.obtenerFrecuenciaPagoPorIdEpresa(Convert.ToInt32(Request.Form["IdEmpresa"])));

                        break;

                    //Opcion del switch para cargar los adicionales seleccionados por el usuario.
                    case "CargarAdicionalescontratados":

                        Response.Write(JsonConvert.SerializeObject(_adicionalcontratadomostrar, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar el total del contrato
                    case "CargarTotal":

                        //Frecuencia de pago
                        var frecuenciaPago = Request.Form["frecuenciaPago"];
                        var montoActual = Request.Form["precioActual"];

                        if (montoActual.Contains("."))
                            montoActual = montoActual.Replace(".", ",");


                        //Costos de la suma de todos los adicionales seleccionados.
                        decimal suma;
                        if (frecuenciaPago == "1")
                        {
                            suma = _adicionalcontratadomostrar.Sum(x => x.Value.Costo * 12);
                        }
                        else
                        {
                            suma = _adicionalcontratadomostrar.Sum(x => x.Value.CostoMensual);
                        }
                        if (frecuenciaPago == "")
                            suma = 0;

                        suma = suma + decimal.Parse(montoActual);


                        Response.Write(suma);

                        break;

                    //Opcion del switch para cargar el plan para utilizar el costo y el nombre en la pantalla.
                    case "CargarPrecioAct":
                        //Obtiene el tipo de contrato del usurio
                        var IdContrato = nTienda.ObtenerIdSuscripcionPorIdEmpresa(Convert.ToInt32(Request.Form["idPerfilEmpresa"]));
                        var monto = PagoAuthorize.ObtenerSuscripcionMonto(IdContrato);

                       

                        Response.Write(JsonConvert.SerializeObject(monto, Formatting.Indented));


                        break;

                    case "CargarDatosTarjeta":
                        var Empresa = Request.Form["idPerfilEmpresa"];
                        int idEmpresa = int.Parse(Empresa);
                        
                        var respuesta = nTienda.ObtenercustomerProfileporIdEmpresa(idEmpresa).Split('-');

                        var customerId = respuesta[0];
                        var ProfilePaymentId = respuesta[1];
                        EPerfilPago eperfil = new EPerfilPago(1,ProfilePaymentId,true);


                        var response = PagoAuthorize.ObtenerInformacionPerfilPago(customerId, eperfil);
                        
                        Response.Write(response.NombreDuenno+" "+response.ApellidoDuenno+"-"+response.NumeroTarjeta);

                        break;


                    case "ProcesarPago":
                        var IDEmpresa = Convert.ToInt32( Request.Form["idPerfilEmpresa"]);
                        var frecuenciaPago2 = Request.Form["frecuenciaPago"];
                        var diferenciaPago = Request.Form["diferenciaPago"]; ;
                        var pagoTotal = Request.Form["pagoTotal"];

                        var tx=decimal.Parse(diferenciaPago);

                        var customerInfo = nTienda.ObtenercustomerProfileporIdEmpresa(IDEmpresa).Split('-');
                        
                        
                        if (frecuenciaPago2 == "2")
                        {
                          // PagoAuthorize.ProcesarPagoTienda(customerInfo[0], customerInfo[1], tx);
                        }


                        break;



                    //Opcion del switch para agregar adicionales por medio del metodo change del input.
                    case "agregaradicional":

                        var idAdicional = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var nombre = Request.Form["NombreAdicional"];

                        var cantidadpaquete = Convert.ToInt32(Request.Form["Cantidadpaquete"]);

                        decimal costo = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US"));
                        decimal costoMensual = Convert.ToDecimal(Request.Form["CostoMensual"], new CultureInfo("en-US"));

                        int cantidad = 0;
                        var esEntero = int.TryParse(Request.Form["CantidaddePaquetes"], out cantidad);

                        if (esEntero)
                        {

                            if (idAdicional == 1)
                            {
                                validarRegaliasInput(cantidadpaquete * cantidad);

                                _adicionalcontratadomostrar[idAdicional].Costo = costo * cantidad;
                                _adicionalcontratadomostrar[idAdicional].CostoMensual = costoMensual * cantidad;

                                _adicionalcontratado[idAdicional].Cantidad = cantidad;

                                _adicionalcontratadomostrar[idAdicional].Cantidad = cantidadpaquete * (cantidad);

                                if ((cantidadpaquete * cantidad) >= activosAdicionalesIlimitados && idAdicional == 1)
                                {
                                    setCostoCero();
                                }
                                else
                                {
                                    recalcularCostos();
                                }

                            }
                            else
                            {
                                if (_adicionalcontratado[idAdicional].CantidadRegalias <= cantidad)
                                {
                                    _adicionalcontratado[idAdicional].Cantidad = cantidad;

                                    _adicionalcontratadomostrar[idAdicional].Cantidad = cantidadpaquete * cantidad;

                                    if (_adicionalcontratado[idAdicional].CantidadRegalias == cantidad || _adicionalcontratadomostrar[1].Cantidad >= activosAdicionalesIlimitados)
                                    {
                                        _adicionalcontratadomostrar[idAdicional].Costo = 0;
                                        _adicionalcontratadomostrar[idAdicional].CostoMensual = 0;
                                    }
                                    else
                                    {
                                        _adicionalcontratadomostrar[idAdicional].Costo = costo * (cantidad - _adicionalcontratadomostrar[idAdicional].CantidadRegalias);
                                        _adicionalcontratadomostrar[idAdicional].CostoMensual = costoMensual * (cantidad - _adicionalcontratadomostrar[idAdicional].CantidadRegalias);
                                    }


                                }
                                else
                                {
                                    _adicionalcontratado[idAdicional].Cantidad = _adicionalcontratado[idAdicional].CantidadRegalias;

                                    _adicionalcontratadomostrar[idAdicional].Cantidad = _adicionalcontratado[idAdicional].CantidadRegalias;
                                    _adicionalcontratadomostrar[idAdicional].Costo = 0;
                                    _adicionalcontratadomostrar[idAdicional].CostoMensual = 0;
                                }

                            }


                        }

                        break;

                    //Opcion del switch para sumar adicionales por de un boton sumar.
                    case "AgregarSumarAdicional":

                        var idAdicionalsumar = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var nombresumar = Request.Form["NombreAdicional"];

                        var cantidadpaquetesumar = Convert.ToInt32(Request.Form["Cantidadpaquete"]);//250



                        var costosumar = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US"));
                        var costoMensualsumar = Convert.ToDecimal(Request.Form["CostoMensual"], new CultureInfo("en-US"));
                   
                        int cantidadsumar = 0;//Cantidad de paquetes
                        var esEnterosumar = int.TryParse(Request.Form["CantidaddePaquetes"], out cantidadsumar);

                        if (esEnterosumar)
                        {

                            //Validamos si el id del adicional (llave del adicional) ya existe en los diccionarios.
                            if (_adicionalcontratado.ContainsKey(idAdicionalsumar) && _adicionalcontratadomostrar.ContainsKey(idAdicionalsumar))
                            {
                                //Si el id es uno se usa la cantidad a sumar, para los demas el paquete a sumar
                                if (idAdicionalsumar == 1)
                                {
                                    _adicionalcontratado[idAdicionalsumar].Cantidad = cantidadsumar;
                                }
                                else
                                {
                                    _adicionalcontratado[idAdicionalsumar].Cantidad += cantidadpaquetesumar;
                                }



                                _adicionalcontratadomostrar[idAdicionalsumar].Cantidad += cantidadpaquetesumar;

                                //Valida si el adicional son activos o si es un adicional diferente y los activos no superan el numero para adicionales ilimitados
                                if (idAdicionalsumar == 1 || (idAdicionalsumar != 1 && _adicionalcontratadomostrar[1].Cantidad < activosAdicionalesIlimitados))
                                {
                                    _adicionalcontratadomostrar[idAdicionalsumar].Costo += costosumar;
                                    _adicionalcontratadomostrar[idAdicionalsumar].CostoMensual += costoMensualsumar;
                                }


                                if (idAdicionalsumar == 1 && (cantidadsumar * cantidadpaquetesumar <= activosAdicionalesIlimitados))
                                {
                                    validadRegalia(true, cantidadsumar * cantidadpaquetesumar);
                                }


                            }

                        }

                        break;

                    //Opcion del switch para restar un adicional por de un boton resta.
                    case "RestarAdicional":

                        var idAdicionalrestar = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var cantidadrestar = Convert.ToInt32(Request.Form["CantidaddePaquetes"]);

                        var cantidadpaqueterestar = Convert.ToInt32(Request.Form["Cantidadpaquete"]);

                        var costorestar = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US"));
                        var costoMensualrestar = Convert.ToDecimal(Request.Form["CostoMensual"], new CultureInfo("en-US"));
                        var cantidadActivos = Convert.ToInt32(Request.Form["cantidadActivos"]);

                        if (_adicionalPlanUsuario[idAdicionalrestar].Cantidad < _adicionalcontratadomostrar[idAdicionalrestar].Cantidad)
                        {
                            if (idAdicionalrestar == 1)
                            {
                                //Sustituye los valores guardados con los nuevos valores.
                                _adicionalcontratado[idAdicionalrestar].Cantidad = cantidadrestar;

                                //Resta 1 vez las variables.
                                _adicionalcontratadomostrar[idAdicionalrestar].Cantidad -= cantidadpaqueterestar;

                                _adicionalcontratadomostrar[idAdicionalrestar].Costo -= costorestar;
                                _adicionalcontratadomostrar[idAdicionalrestar].CostoMensual -= costoMensualrestar;

                                validadRegalia(false, cantidadActivos);

                            }
                            else if (_adicionalcontratadomostrar[idAdicionalrestar].Cantidad > _adicionalPlanUsuario[idAdicionalrestar].Cantidad)
                            {
                                //Sustituye los valores guardados con los nuevos valores.
                                _adicionalcontratado[idAdicionalrestar].Cantidad = cantidadrestar;

                                //Resta 1 vez las variables.
                                _adicionalcontratadomostrar[idAdicionalrestar].Cantidad -= cantidadpaqueterestar;
                            }

                            //Valida que los activos no superan el numero para adicionales ilimitados y que la resta no sea menor a las regalias

                            if (idAdicionalrestar != 1 && _adicionalcontratadomostrar[1].Cantidad < activosAdicionalesIlimitados && _adicionalcontratadomostrar[idAdicionalrestar].Cantidad >= _adicionalPlanUsuario[idAdicionalrestar].Cantidad)
                            {
                                _adicionalcontratadomostrar[idAdicionalrestar].Costo -= costorestar;
                                _adicionalcontratadomostrar[idAdicionalrestar].CostoMensual -= costoMensualrestar;
                            }
                        }


                        break;

                }


            }
            catch (Exception ex)

            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);

            }

        }

       

        private decimal calcularPrecioFinal(ETipoPlanes infoPlan, string frecuencia)
        {
            var costo = frecuencia == "1" ? infoPlan.Costo : infoPlan.CostoMensual;

            decimal costoTotal = 0.00M;

            //Costos de la suma de todos los adicionales seleccionados.
            if (frecuencia == "1")
            {
                costoTotal = _adicionalcontratadomostrar.Sum(x => x.Value.Costo);
            }
            else
            {
                costoTotal = _adicionalcontratadomostrar.Sum(x => x.Value.CostoMensual);
            }


            //Suma del costo del plan y los adicionales.
            costoTotal += costo;

            costoTotal = frecuencia == "1" ? costoTotal * 12 : costoTotal;

            return costoTotal;

        }
    }
}
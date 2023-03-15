using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using Newtonsoft.Json;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public partial class AdicionalesContratoAjax : System.Web.UI.Page
    {
        NUsuarioEmpresa nUsuarioEmpresa = new NUsuarioEmpresa();
        private int numRegalia = 2;
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

        private void crearEntidades(int idAdicional, int cantidad, int cantidadpaquete, string nombre, decimal costo)
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
            adicionelesContratadosmostrar.Nombre = nombre;
            adicionelesContratadosmostrar.Descripcion = "";
            adicionelesContratadosmostrar.CantidadRegalias = cantidadRegalias;
            adicionelesContratadosmostrar.Costo = costo * cantidad;

            //Añade a los diccionarios las entidades anterirormente creadas.
            _adicionalcontratado.Add(idAdicional, (adicionelesContratados));
            _adicionalcontratadomostrar.Add(idAdicional, (adicionelesContratadosmostrar));
        }

        private void validadRegalia(Boolean suma,int numActivos)
        {
            
            if (suma) 
            {
                if (numActivos == 500 || numActivos == 1000 || numActivos == 1500 || numActivos == 2000)
                {
                    agregarRegalia(numRegalia);
                }

            } else
            {
                if (numActivos ==250 || numActivos==750 || numActivos == 1250 || numActivos == 1750)
                {
                    retirarRegalia(numRegalia);
                }
            }
        }


        private void validarRegaliasInput(int numActivos)
        {
            int cantidadActualActivos = _adicionalcontratado[1].Cantidad;

            if (cantidadActualActivos < numActivos)
            {
                if(numActivos == 250)
                {
                    setRegalia(numRegalia);
                } else if(numActivos >= 500 && numActivos <= 750)
                {
                    setRegalia(numRegalia * 2);
                }
            }
        }

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

        private void agregarRegalia(int numRegalias)
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1) 
                {
                    _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad += numRegalias;
                    _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias += numRegalias;

                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad += numRegalias;
                    _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias += numRegalias;
                }
            }
            
        }

        private void retirarRegalia(int numRegalias)
        {
            var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();

            foreach (var paquete in ePaqueteAdicionales)
            {
                if (paquete.IdPaqueteContratado != 1)
                {
                    if (_adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias >= (numRegalias*2))
                    {
                        _adicionalcontratado[paquete.IdPaqueteContratado].Cantidad -= numRegalias;
                        _adicionalcontratado[paquete.IdPaqueteContratado].CantidadRegalias -= numRegalias;

                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].Cantidad -= numRegalias;
                        _adicionalcontratadomostrar[paquete.IdPaqueteContratado].CantidadRegalias -= numRegalias;
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

                        var ePaqueteAdicionales = nUsuarioEmpresa.CargarAdicionales();
                        
                        Response.Write(JsonConvert.SerializeObject(ePaqueteAdicionales, Formatting.Indented));

                        foreach(var paquete in ePaqueteAdicionales)
                        {
                            crearEntidades(
                            paquete.IdPaqueteContratado,
                            paquete.IdPaqueteContratado == 1?1:2,
                            paquete.Cantidad,
                            paquete.Nombre,
                            0
                            );
                        }
                        

                        break;

                    //Opcion del switch para cargar los adicionales seleccionados por el usuario.
                    case "CargarAdicionalescontratados":
                        
                        Response.Write(JsonConvert.SerializeObject(_adicionalcontratadomostrar, Formatting.Indented));
                        
                        break;

                    //Opcion del switch para cargar el total del contrato
                    case "CargarTotal":
                        
                        //Costo del plan seleccionado.
                        var precioplan = Convert.ToDecimal(Request.Form["precioplan"]);

                        //Costos de la suma de todos los adicionales seleccionados.
                        var suma = _adicionalcontratadomostrar.Sum(x => x.Value.Costo);

                        //Suma del costo del plan y los adicionales.
                        suma = suma + precioplan;

                        Response.Write(suma);

                        break;

                    //Opcion del switch para cargar el plan para utilizar el costo y el nombre en la pantalla.
                    case "CargarPrecio":

                        var codigoplan = Convert.ToInt32(Request.Form["CodigoPlan"]);

                        var etipo = nUsuarioEmpresa.CargarPlan(codigoplan);

                        Response.Write(JsonConvert.SerializeObject(etipo, Formatting.Indented));

                        break;

                    //Opcion del switch para agregar adicionales por medio del metodo change del input.
                    case "agregaradicional":

                        var idAdicional = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var nombre = Request.Form["NombreAdicional"];

                        var cantidadpaquete = Convert.ToInt32(Request.Form["Cantidadpaquete"]);

                        decimal costo = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US"));

                       // var costo = Convert.ToDecimal(Request.Form["Costo"]);
                        // decimal var1 = Convert.ToDecimal("-37.7130883", new CultureInfo("en-US"));

                        int cantidad = 0;
                        var esEntero = int.TryParse(Request.Form["CantidaddePaquetes"], out cantidad);

                        if (esEntero)
                        {
                            
                            if(idAdicional == 1)
                            {
                                validarRegaliasInput(cantidadpaquete);
                                if (cantidad == 1)
                                {
                                    _adicionalcontratadomostrar[idAdicional].Costo = 0;//La primera unidad es de regalia
                                }
                                _adicionalcontratado[idAdicional].Cantidad = cantidad;

                                _adicionalcontratadomostrar[idAdicional].Cantidad = cantidadpaquete * (cantidad);
                                
                                
                            }
                            else
                            {
                                _adicionalcontratado[idAdicional].Cantidad = cantidad + 1;//Mas 1 por la regalia del plan 

                                _adicionalcontratadomostrar[idAdicional].Cantidad = cantidadpaquete * (cantidad +1);
                                _adicionalcontratadomostrar[idAdicional].Costo = costo * cantidad;
                            }
                            

                        }

                        break;

                    //Opcion del switch para sumar adicionales por de un boton sumar.
                    case "AgregarSumarAdicional":

                        var idAdicionalsumar = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var nombresumar = Request.Form["NombreAdicional"];

                        var cantidadpaquetesumar = Convert.ToInt32(Request.Form["Cantidadpaquete"]);//250

                      

                        var costosumar = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US"));
                        /*  decimal costosumar = 0.0M;

                          var aa = decimal.TryParse(Request.Form["Costo"], out costosumar);
                          */
                        int cantidadsumar = 0;//Cantidad de paquetes
                        var esEnterosumar = int.TryParse(Request.Form["CantidaddePaquetes"], out cantidadsumar);

                        if (esEnterosumar)
                        {

                            //Validamos si el id del adicional (llave del adicional) ya existe en los diccionarios.
                            if (_adicionalcontratado.ContainsKey(idAdicionalsumar) && _adicionalcontratadomostrar.ContainsKey(idAdicionalsumar))
                            {

                                if (idAdicionalsumar == 1)
                                {
                                    _adicionalcontratado[idAdicionalsumar].Cantidad = cantidadsumar;
                                } else
                                {
                                    _adicionalcontratado[idAdicionalsumar].Cantidad += cantidadpaquetesumar;
                                }
                                

                                //Si el adicional ya estiste entonces suma 1 vez las variables.
                                _adicionalcontratadomostrar[idAdicionalsumar].Cantidad += cantidadpaquetesumar;
                                if (idAdicionalsumar == 1 && cantidadsumar == 2)
                                {
                                    costosumar += 0.01M;
                                }
                                _adicionalcontratadomostrar[idAdicionalsumar].Costo += costosumar;

                                var x = _adicionalcontratado[idAdicionalsumar].Cantidad;
                                var y = _adicionalcontratadomostrar[idAdicionalsumar].Cantidad;

                                if (idAdicionalsumar == 1)
                                {
                                    validadRegalia(true,cantidadsumar * cantidadpaquetesumar);
                                }

                                
                            }
                            else
                            {
                                crearEntidades(idAdicionalsumar, cantidadsumar, cantidadpaquetesumar, nombresumar, costosumar);
                                
                            }

                        }

                        break;

                    //Opcion del switch para restar un adicional por de un boton resta.
                    case "RestarAdicional":

                        var idAdicionalrestar = Convert.ToInt32(Request.Form["IdAdicional"]);

                        var cantidadrestar = Convert.ToInt32(Request.Form["CantidaddePaquetes"]);

                        var cantidadpaqueterestar = Convert.ToInt32(Request.Form["Cantidadpaquete"]);

                        var costorestar = Convert.ToDecimal(Request.Form["Costo"], new CultureInfo("en-US")); ;

                        //Si el adicional ya estiste entonces sustituye los valores guardados con los nuevos valores.
                        _adicionalcontratado[idAdicionalrestar].Cantidad = cantidadrestar;

                        //Si el adicional ya estiste entonces resta 1 vez las variables.
                        _adicionalcontratadomostrar[idAdicionalrestar].Cantidad -= cantidadpaqueterestar;

                        if (idAdicionalrestar == 1 && cantidadrestar == 1)
                        {
                            costorestar += 0.01M;
                        }

                        _adicionalcontratadomostrar[idAdicionalrestar].Costo -= costorestar;

                        if (idAdicionalrestar == 1)
                        {
                            validadRegalia(false, cantidadrestar * cantidadpaqueterestar);
                        }

                        //Validacion para saber si la cantidad solicitada del adicional es 0, si es así se elimina el adicional del diccionario.
                        if (_adicionalcontratado[idAdicionalrestar].Cantidad <= 0)
                        {
                            _adicionalcontratado.Remove(idAdicionalrestar);
                            _adicionalcontratadomostrar.Remove(idAdicionalrestar);
                        }


                        break;

                    //Opcion del switch ingregar el contrato por de un boton.
                    case "InsertarContrato":

                        /*info del usuario 

                        var UsuarioEmpresaJson = Request.Form["InfoUsuariotarjeta"];

                        */

                        var correo = Request.Form["correoUsuario"];

                        var frecuenciapago = Convert.ToInt32(Request.Form["frecuencia"]);

                        var contrato = Convert.ToInt32(Request.Form["tipocontrato"]);

                        var ResultadoAdicionales = nUsuarioEmpresa.InsertarContrato(correo, frecuenciapago, contrato, _adicionalcontratado.Values.ToList());

                        Response.Write(JsonConvert.SerializeObject(ResultadoAdicionales, Formatting.Indented));

                        break;

                }


            }
            catch (Exception ex)

            {


            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.GestionServicio
{
    public partial class AjaxEjemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            try
            {
                switch (Request.Form["opciones"])
                {
                    case "opcion1":
                        Response.Write("Hola1");
                       break;

                    case "opcion2":
                        Response.Write("Hola2");
                        break;
                    case "opcion3":
                        Response.Write("Hola3");
                        break;

                    case "opcion4":
                        Response.Write("Hola4");
                        break;
                    case "opcion5":
                        Response.Write("Hola5");
                        break;
                }
            }
            catch
            {
                Response.Write("ErrorAjax");
            }
        }
    }
}
var i = 0; //Iterador para desaparecer el div creado con laa funcionnes

var alertas = function () {
    //Función para dar mensje correcto
    this.success = (encabezado ,mensaje) => {

        var div = document.getElementById("alertas"); //Recordar tener un div con id alertas en el htmal para que el código funcione

       
        var divSuccess = document.createElement("div");
        divSuccess.id ="popup"+i;
        divSuccess.className = "popup-alertas-ai w-clearfix";
        divSuccess.style.position = "fixed";
        divSuccess.style.zIndex = "2000";

        var h5Succes = document.createElement("h5");
        h5Succes.className = "titulo-alertas"
        h5Succes.innerText = encabezado;

        var pSuccess = document.createElement("p");
        pSuccess.className = "mensaje-alerta";
        pSuccess.innerText = mensaje;


        var imgSuccess = document.createElement("img");
        imgSuccess.src = "../images/exito.png";
        imgSuccess.loading = "lazy";
        imgSuccess.width = "48";
        imgSuccess.className = "img-exito-pp";

        divSuccess.appendChild(h5Succes);
        divSuccess.appendChild(pSuccess);
        divSuccess.appendChild(imgSuccess);
        div.appendChild(divSuccess);

        var x = setTimeout(function () {
            divSuccess.style.display = "none";
            clearTimeout(x);
        }, 3500);


        if (i > 0) {
            var margenpop = 110;
            for (var cont = i - 1; cont >= 0; cont--) {
                var variable = "popup" + cont;
                var margen = margenpop + "px";
                var popviejo = document.getElementById(variable);
                popviejo.style.margin = "" + margen + " 20px 10px 0";
                margenpop = margenpop + 110;

                if (margenpop > 440) {
                    margenpop = 110;
                }
            }
        }
        i++;

    }
    //Función para dar mensje de error
    this.error = (encabezado, mensaje) => {

        var div = document.getElementById("alertas");//Recordar tener un div con id alertas en el htmal para que el código funcione

        var divError = document.createElement("div");
        divError.className = "popup-alertas-ai w-clearfix";
        divError.id = "popup" + i;
        divError.style.position = "fixed";
        divError.style.zIndex = "2000";

        var h5Error = document.createElement("h5");
        h5Error.className = "titulo-alertas"
        h5Error.innerText = encabezado;

        var pError = document.createElement("p");
        pError.className = "mensaje-alerta";
        pError.innerText = mensaje;


        var imgError = document.createElement("img");
        imgError.src = "../images/error.png";
        imgError.loading = "lazy";
        imgError.width = "48";
        imgError.className = "img-alerta-pp";

        divError.appendChild(h5Error);
        divError.appendChild(pError);
        divError.appendChild(imgError);
        div.appendChild(divError);


        var x = setTimeout(function () {
            divError.style.display = "none";
            clearTimeout(x);
        }, 6000);


        if (i > 0) {
            var margenpop = 110;
            for (var cont = i - 1; cont >= 0; cont--) {
                var variable = "popup" + cont;
                var margen = margenpop + "px";
                var popviejo = document.getElementById(variable);
                popviejo.style.margin = "" + margen + " 20px 10px 0";
                margenpop = margenpop + 110;

                if (margenpop > 440) {
                    margenpop = 110;
                }
            }
        }
        i++;

    }
    //Función para dar mensje informativo
    this.info = (encabezado, mensaje) => {

        var div = document.getElementById("alertas");//Recordar tener un div con id alertas en el htmal para que el código funcione

        var divAlert = document.createElement("div");
        divAlert.className = "popup-alertas-ai w-clearfix";
        divAlert.id = "popup" + i;
        divAlert.style.position = "fixed";
        divAlert.style.zIndex = "2000";

        var h5Alert = document.createElement("h5");
        h5Alert.className = "titulo-alertas"
        h5Alert.innerText = encabezado;

        var pAlert = document.createElement("p");
        pAlert.className = "mensaje-alerta";
        pAlert.innerText = mensaje;


        var imgAlert = document.createElement("img");
        imgAlert.src = "../images/alerta.png";
        imgAlert.loading = "lazy";
        imgAlert.width = "48";
        imgAlert.className = "img-alerta-pp";

        divAlert.appendChild(h5Alert);
        divAlert.appendChild(pAlert);
        divAlert.appendChild(imgAlert);
        div.appendChild(divAlert);

        var x = setTimeout(function () {
            divAlert.style.display = "none";
            clearTimeout(x);
        }, 6000);


        if (i > 0) {
            var margenpop = 110;
            for (var cont = i - 1; cont >= 0; cont--) {
                var variable = "popup" + cont;
                var margen = margenpop + "px";
                var popviejo = document.getElementById(variable);
                popviejo.style.margin = "" + margen + " 20px 10px 0";
                margenpop = margenpop + 110;

                if (margenpop > 440) {
                    margenpop = 110;
                }
            }
        }
        i++;

    }

}
//constructor de la entidad
var alertas = new alertas();
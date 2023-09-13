var urlCuponAjax = 'CuponAjax.aspx';
var urlContratoAjax = 'AdicionalesContratoAjax.aspx';

$(document).ready(function () {

    sessionStorage.setItem("CodigoCupon", null);
 

    document.getElementById("btnValidarCupon").addEventListener("click", function () {
        var codigo = document.getElementById("txtCodigoPromo");
        RecalcularPrecioCupon(codigo.value);
        ValidarCupon(codigo.value);
        
    });
});



//CODIGO PARA VALIDAR EL CUPON
function ValidarCupon(codigo) {
    var botonRegistrarCupon = document.getElementById("btnValidarCupon")
    var textCodigoCupon = document.getElementById("txtCodigoPromo");
    $.post(urlCuponAjax, {
        option: 'VerificarCodigo',
        codigo: codigo
    }, function (data, error) {
        var verificar = data.toString();

        var labelConfirmaCupon = document.getElementById("lblConfirmaCupon");
        if (verificar == "Existe") {
         
            labelConfirmaCupon.innerHTML = "El cupon: " + codigo + " es valido."
            labelConfirmaCupon.value = codigo;
            textCodigoCupon.value = "";
            textCodigoCupon.disabled = true;
            sessionStorage.setItem("CodigoCupon", codigo);
            botonRegistrarCupon.disabled = true;
            botonRegistrarCupon.style.backgroundColor = '#d3b338';


            contrato.CargarPrecio();
            contrato.CargarTotal();
          
            
            
            
        } else {
            labelConfirmaCupon.innerHTML = "El cupon: " + codigo + " es invalido.";
            labelConfirmaCupon.value = codigo;
            document.getElementById("txtCodigoPromo").value = "";
            sessionStorage.setItem("CodigoCupon", null);
        }
    });

}


function RecalcularPrecioCupon(codigo) {

    $.post(urlContratoAjax, {
        option: 'recalcularPrecioCupon',
        codigoCupon: codigo
    }, function (data, error) {
        var result = data.toString();

    });

}
'use strict';
var id_UbicacioA;

window.addEventListener('load', (event) => {

    /*ConsultaCantidadActivoUbicacion();*/
    ConsultaCantidadActivo();



});




//A

this.ConsultaCantidadActivo = function () {
    $.post("Graficos/UbicacionA/UbicacionAAjax.aspx", {
        option: "ConsultarCantidad_ActivosUbicacionA",


    }, function (data, error) {
        var nombre = [];
        var cantidad = [];
        var IdUbicacionA = [];
        var json = JSON.parse(data)



        for (var i = 0; i < json.length; i++) {
            IdUbicacionA.push(json[i].IdUbicacion);
            cantidad.push(json[i].Cantidad);
            nombre.push(json[i].Nombre);


        }

        const datasets = [{
            label: 'UbicacionA',
            data: cantidad,
            backgroundColor: getRandomColorEachUbicacion(nombre.length)


        }]
        const ctx = document.getElementById("myChart").getContext('2d');
        const myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: nombre,
                datasets
            },
            options: {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
                    }],
                    xAxes: [{
                      
                        ticks: {
                            beginAtZero: false,
                           

                        }
                    }],


                },
                onClick(evt) {

                    const points = myChart.getElementsAtEventForMode(evt, 'nearest', { intersect: true }, true);

                    if (points.length) {
                        const firstPoint = points[0];
                        const id = IdUbicacionA[firstPoint._index]
                        //const label = myChart.data.labels[firstPoint._index];
                        //const value = myChart.data.datasets[firstPoint._datasetIndex].data[firstPoint._index];
                        ConsultaCantidadActivoUbicacionB2(id);


                    }

                }
            }
        });
    });
}


function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

function getRandomColorEachUbicacion(count) {
    var data = [];
    for (var i = 0; i < count; i++) {
        data.push(getRandomColor());
    }
    return data;
}


//this.ConsultaCantidadActivoUbicacionB = function (id_UbicacioA) {
//    $.post("Graficos/UbicacionA/UbicacionAAjax.aspx", {
//        option: "ConsultarCantidad_ActivosUbicacionB",
//        id: id_UbicacioA

//    }, function (data, error) {

//        var id_UbicacionB = [];
//        var nombre = [];
//        var cantidad = [];
//        var json = JSON.parse(data)


//        for (var i = 0; i < json.length; i++) {
//            id_UbicacionB.push(json[i].IdUbicacion)
//            cantidad.push(json[i].Cantidad);
//            nombre.push(json[i].Nombre);


//        }



//        var datasets = [{
//            label: 'UbicacionB',
//            data: cantidad,
//            backgroundColor: getRandomColorEachUbicacion(nombre.length)


//        }]

//        //var div = document.getElementById("ContieneCanvas");
//        //div.innerHTML = "";
//        //var canvas = document.createElement("canvas");
//        //div.appendChild(canvas);
//        const ctx = document.getElementById("speedChart2").getContext('2d');
//        /*var ctx = canvas.getContext('2d');*/



//        var myChart = new Chart(ctx, {
//            type: 'bar',
//            data: {
//                labels: nombre,
//                datasets
//            },
//            options: {
//                scales: {
//                    yAxes: [{
//                        ticks: {
//                            beginAtZero: true
//                        }
//                    }]
//                }
//            },

//            onClick(evt) {

//                const points = myChart.getElementsAtEventForMode(evt, 'nearest', { intersect: true }, true);

//                if (points.length) {
//                    const firstPoint = points[0];
//                    const id = id_UbicacionB[firstPoint._index]
//                    //const label = myChart.data.labels[firstPoint._index];
//                    //const value = myChart.data.datasets[firstPoint._datasetIndex].data[firstPoint._index];



//                    ConsultaCantidadActivoUbicacionC(id);


//                }

//            }
//        });
//    });
//}

this.ConsultaCantidadActivoUbicacionB2 = function (id_UbicacioA) {
    $.post("Graficos/UbicacionA/UbicacionAAjax.aspx", {
        option: "ConsultarCantidad_ActivosUbicacionB",
        id: id_UbicacioA

    }, function (data, error) {
        var json = JSON.parse(data);
        var id_UbicacionB = [];
        var nombre = [];
        var cantidad = [];
     


        for (var i = 0; i < json.length; i++) {
            id_UbicacionB.push(json[i].IdUbicacion)
            cantidad.push(json[i].Cantidad);
            nombre.push(json[i].Nombre);


        }



        var datasets = [{
            label: 'UbicacionB',
            data: cantidad,
            backgroundColor: getRandomColorEachUbicacion(nombre.length)


        }]

        var div = document.getElementById("ContieneCanvas");
        div.innerHTML = "";
        var canvas = document.createElement("canvas");
        div.appendChild(canvas);

        var ctx = canvas.getContext('2d');



        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: nombre,
                datasets
            },
            options: {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
                    }]
                },
            

                onClick(evt) {

                    const points = myChart.getElementsAtEventForMode(evt, 'nearest', { intersect: true }, true);

                    if (points.length) {
                        const firstPoint = points[0];
                        const id = id_UbicacionB[firstPoint._index]
                        //const label = myChart.data.labels[firstPoint._index];
                        //const value = myChart.data.datasets[firstPoint._datasetIndex].data[firstPoint._index];



                        ConsultaCantidadActivoUbicacionC(id);


                    }

                }
            }
        });
    });
}
//C
this.ConsultaCantidadActivoUbicacionC = function (idUbicacionB) {
    $.post("Graficos/UbicacionA/UbicacionAAjax.aspx", {
        option: "ConsultarCantidad_ActivosUbicacionC",
        id: idUbicacionB

    }, function (data, error) {
        var json = JSON.parse(data);
        var id_UbicacionC = [];
        var nombre = [];
        var cantidad = [];
       


        for (var i = 0; i < json.length; i++) {
            id_UbicacionC.push(json[i].IdUbicacion)
            cantidad.push(json[i].Cantidad);
            nombre.push(json[i].Nombre);


        }



        var datasets = [{
            label: 'UbicacionC',
            data: cantidad,
            backgroundColor: getRandomColorEachUbicacion(nombre.length)


        }]

        var div2 = document.getElementById("ContieneCanvasC");
        div2.innerHTML = "";
        var canvas = document.createElement("canvas");
        div2.appendChild(canvas);

        var ctx = canvas.getContext('2d');



        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: nombre,
                datasets
            },
            options: {
                responsive: true,
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true,
                           
                        }
                    }],
                    xAxes: [{
                        gridLines: {
                            //display: false,
                            drawBorder: true,
                            padding: 20,
                            offsetGridLines: true
                        },
                        ticks: {
                            beginAtZero: false,
                         
                           
                        }
                    }],
                },
                onClick(evt) {

                    const points = myChart.getElementsAtEventForMode(evt, 'nearest', { intersect: true }, true);

                    if (points.length) {
                        const firstPoint = points[0];
                        const id = id_UbicacionC[firstPoint._index]
                        //const label = myChart.data.labels[firstPoint._index];
                        //const value = myChart.data.datasets[firstPoint._datasetIndex].data[firstPoint._index];



                        ConsultaCantidadActivoUbicacionD(id);


                    }

                }
            }
           
        });
    });
}
//D
this.ConsultaCantidadActivoUbicacionD = function (idUbicacionC) {
    $.post("Graficos/UbicacionA/UbicacionAAjax.aspx", {
        option: "ConsultarCantidad_ActivosUbicacionD",
        id: idUbicacionC

    }, function (data, error) {

        var id_UbicacionD = [];
        var nombre = [];
        var cantidad = [];
        var json = JSON.parse(data)


        for (var i = 0; i < json.length; i++) {
            id_UbicacionD.push(json[i].IdUbicacion)
            cantidad.push(json[i].Cantidad);
            nombre.push(json[i].Nombre);


        }



        var datasets = [{
            label: 'UbicacionD',
            data: cantidad,
            backgroundColor: getRandomColorEachUbicacion(nombre.length)


        }]

        var div = document.getElementById("ContieneCanvasD");
        div.innerHTML = "";
        var canvas = document.createElement("canvas");
    
        //canvas.style.width = "300px";
        ////canvas.style.height = "400";
        div.appendChild(canvas);

        var ctx = canvas.getContext('2d');



        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: nombre,
                datasets
            },
            options: {
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true,
                           
                        }
                    }],
                    //xAxes: [{
                    //    gridLines: {
                    //        //display: false,
                    //        drawBorder: false,
                    //        padding: 20,
                    //        offsetGridLines: true
                    //    },
                    //    ticks: {
                    //        fontSize: 8,
                    //        beginAtZero: true,
                    //    }
                    //}],
                },
            }
            
        });
    });
}
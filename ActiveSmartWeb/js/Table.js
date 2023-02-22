Vue.component('TableBotones', {
    props: {
        headers: Object,
        datatable: [],
        buttons: [],    
        idDiv: String,
        tableName: String

    },
    render(h) { 
        var self = this
        let TableSizeArray = []
        let RowSizeArray = []
        var columnsHeaders = this.headers.headersInfo.length;
        for (let i = 0; i < columnsHeaders; i += 1) {
            RowSizeArray.push(h('td', {               
                domProps: {
                    innerText: this.headers.headersInfo[i]
                },
                style: {
                    padding: '5px',
                    'background-color': '#444',
                    'font-family': 'Lato,sans-serif',
                    color: '#fff',
                    'font-size': '12px',
                    'line-height': '14px',
                    'font-weight': '400',
                    'text-align': 'center',
                    border: 'solid 1px #fff'
                }

            }, [
            ]))
        }

        for (let i = 0; i < this.buttons.length; i += 1) {
            RowSizeArray.push(h('td', {
                domProps: {
                    innerText: ''
                },
                style: {
                    'min-width': '20px',
                    padding: '5px',
                    'background-color': '#444',
                    'font-family': 'Lato,sans-serif',
                    color: '#fff',
                    'font-size': '12px',
                    'line-height': '14px',
                    'font-weight': '400',
                    'text-align': 'center',
                    border: 'solid 1px #fff'
                }
            }, [
            ]))
        }
       

        TableSizeArray.push(h('tr', {           
        }, [RowSizeArray]))

        for (let y = 0; y < this.datatable.length; y += 1) {
            let rowsData = []
            for (let x = 1; x < this.datatable[y].length; x += 1) {
                rowsData.push(h('td', {                   
                    domProps: {
                        innerText: this.datatable[y][x]
                    },
                    style: {
                        width: 'auto',
                        height: 'auto',
                        padding: '2.5px 5px',
                        'justify-content': 'center',
                        'align-items': 'center',
                        'background-color': '#f4f4f4',
                        'text-align': 'center',
                        border: 'solid 1px #e3e3e3'
                    }
                }, [
                ]))
            }

            for (let i = 0; i < this.buttons.length; i += 1) {
                rowsData.push(h('td', {
                    style: {
                        'background-color': '#f4f4f4',                      
                        border: 'solid 1px #e3e3e3'
                    }                   
                }, [
                        h('a', {
                            attrs: {
                                class: 'linkblockCelda amarillo',
                            },
                        on: {
                            click: e => {
                                this.buttons[i][0](this.datatable[y]);
                            }
                        }
                    }, [
                        h('img', {
                            attrs: {
                                class: 'image-celdatabla',
                                src: this.buttons[i][1]
                            },
                            style: {
                                height: '20',
                                width: '20'
                            }
                        }, [
                        ])
                    ])
                ]))
            }
            TableSizeArray.push(h('tr', {               
            }, [rowsData]))
        }

        let a_pages = []
        var rowsToShow = 5;
        var numPages = this.datatable.length / rowsToShow;
        for (let x = 0; x < numPages; x++)
        {
            a_pages.push(h('a', {               
                domProps: {
                    innerText: x+1
                },
                style: {
                    margin: '5px'
                },
                on: {
                    click: e => {
                        this.Paginacion(x, rowsToShow);
                        $('#div' + this.tableName).children('a').attr('style', 'margin: 5px');                     
                        e.target.style = 'background-color: #eabb00; margin: 5px'
                    }
                }
            }))
        }

        var divpages = h('div', {
            attrs: { id: 'div' + this.tableName }
        }, [a_pages])

        return h('div', {
            attrs: { id: this.idDiv},
            style: {
                overflow: 'auto'          
            }
        }, [
                h('table', { 
                    attrs: { id: this.tableName },
                 style: { 
                     width: '100%'                  
                }
                }, [TableSizeArray])

                ,
                divpages
        ])


    },
    methods: {
        Paginacion: function (x, rowsToShow) {          
            $('#' + this.tableName + ' tr').hide();
            $('#' + this.tableName + ' tr').slice(0, 1).show();
            if (x == 0) {
                $('#' + this.tableName + '  tr').slice(1, rowsToShow + 1).show();
            }
            else {
                $('#' + this.tableName + '  tr').slice((x * rowsToShow) + 1, ((x + 1) * rowsToShow) + 1).show();
            }
        }
    },

    mounted: function () {
        //console.log('mounted');
        //this.Paginacion(0, 5);
    },

    updated: function () {
        //console.log('updated');
        this.Paginacion(0, 5);
    }
})


var css = document.createElement('style');
css.type = 'text/css';

css.innerHTML = '.image-celdatabla {width: 100 %;height:30px;padding-top: 7px;padding-bottom: 7px;}'
    + '.image-celdatabla:hover { -webkit-filter:brightness(400%); filter: brightness(400%);}'


var linkblock2 = document.createElement('style');
linkblock2.type = 'text/css';

linkblock2.innerHTML = '.linkblockCelda {display: -webkit-box;display: -webkit-flex;display: -ms-flexbox;display: flex;'
    + 'width: 100%;height: 100%;-webkit-box-pack:center;-webkit-justify-content: center;-ms-flex-pack: center;'
    + 'justify-content: center;-webkit-box-align: center;-webkit-align-items: center;-ms-flex-align: center;align-items: center;}'
    + '.linkblockCelda.amarillo:hover {background-color: #eabb00;}'


var body = document.getElementsByTagName('body');
body[0].appendChild(css);
body[0].appendChild(linkblock2);

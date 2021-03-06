﻿window.pageDrink = {


    selecSizetDrinks: function () {
        $.ajax({

            url: 'api/Size/SelectAllSizes',
            type: 'POST',
            dataType: 'json',
            success: function (msg) {

                $.each(msg, function () {
                    $("#sizedrinkselect").append($("<option>  </option>").val(this['PK_SIZE']).html(this['SIZETYPE']));

                });

                $('select').material_select();

            }
        });
    },

    selecTypetDrinks: function () {
        $.ajax({

            url: 'api/Type/SelectAllTypes',
            type: 'POST',
            dataType: 'json',
            success: function (msg) {

                $.each(msg, function () {
                    $("#typedrinkselect").append($("<option>  </option>").val(this['PK_TYPE']).html(this['NAME']));

                });

                $('select').material_select();

            }
        });
    },

    GetNumberOfDrinksByType: function () {
        $.ajax({

            url: 'api/Drink/GetNumberOfDrinksByType',
            type: 'POST',
            dataType: 'json',
            success: function (data) {

                $('#drinkChart').highcharts({
                    chart: {
                        plotBackgroundColor: null,
                        plotBorderWidth: null,
                        plotShadow: false,
                        type: 'pie'
                    },
                    title: {
                        text: 'Percentage of registered drinks per type'
                    },
                    tooltip: {
                        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                    },
                    plotOptions: {
                        pie: {
                            allowPointSelect: true,
                            cursor: 'pointer',
                            dataLabels: {
                                enabled: true,
                                format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                                style: {
                                    color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                                }
                            }
                        }
                    },
                    series: [{
                        name: 'Brands',
                        colorByPoint: true,
                        data: [{
                            name: 'Beer',
                            y: data.Type2
                        }, {
                            name: 'Drink/Coquitel',
                            y: data.Type1,
                            sliced: true,
                            selected: true
                        }, {
                            name: 'Wine and Others',
                            y: data.Type3
                        },
                        {
                            name: 'Destilled',
                            y: data.Type4
                        }]
                    }]
                });

            }
        });
    },

    selectAllDrinks: function () {
        $.ajax({

            url: 'api/Drink/SelectAllDrinks',
            type: 'POST',
            dataType: 'json',
            success: function (data) {

                $('#drinkTable').DataTable({
                    "bScrollInfinite": true,
                    "bScrollCollapse": true,
                    "sScrollY": "500px",
                    "bPaginate": false,
                    data: data,
                    columns: [
                        { data: 'PK_DRINK' },
                        { data: 'PHOTO' },
                        { data: 'NAME' },
                        { data: 'TYPENAME' },
                        { data: 'SIZENAME' },
                        { data: 'PRICE' }
                    ]
                });

            }
        });
    },

    createDrink: function () {

        var x = $DrinkPicture;

        $.ajax({

            url: 'api/Drink/CreateNewDrink',
            type: 'POST',
            dataType: 'json',
            data: {
                "NAME": $('#drinkname').val(),
                "PHOTOCODED": $DrinkPicture,
                "FK_SIZE": $('#sizedrinkselect').val(),
                "FK_TYPE": $('#typedrinkselect').val(),
                "PRICE": $('#pricedrink').val()
            },
            success: function (e) {
                var $toastContent = e;
                Materialize.toast($toastContent, 2000);

                setTimeout(function () { location.reload(); },2000);
            },
            error: function (e) {
                var $toastContent = e;
                Materialize.toast($toastContent, 3000);
            }

        });

    },

    getChartInfos: function () {

        $('#drinkChart').highcharts({
            chart: {
                plotBackgroundColor: null,
                plotBorderWidth: null,
                plotShadow: false,
                type: 'pie'
            },
            title: {
                text: 'Percentage of registered drinks per type'
            },
            tooltip: {
                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: true,
                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                        style: {
                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                        }
                    }
                }
            },
            series: [{
                name: 'Brands',
                colorByPoint: true,
                data: [{
                    name: 'Beer',
                    y: 50
                }, {
                    name: 'Drink/Coquitel',
                    y: 34,
                    sliced: true,
                    selected: true
                }, {
                    name: 'Wine and Others',
                    y: 22
                },
                {
                    name: 'Destilled',
                    y: 4
                }]
            }]
        });

    },

    getPictureToBase64: function () {
        var filesSelected = document.getElementById("pictureinput").files;
        if (filesSelected.length > 0) {
            var fileToLoad = filesSelected[0];

            var fileReader = new FileReader();

            fileReader.onload = function (fileLoadedEvent) {
                $DrinkPicture = fileLoadedEvent.target.result; // <--- data: base64

            }
            fileReader.readAsDataURL(fileToLoad);
        }
    },


    events: function () {

        $('body').delegate('button[name="btnCreateDrink"]', 'click', function () { pageDrink.createDrink(); })

    },

    config: function () {

        pageDrink.events();

    },

    init: function () {

        pageDrink.config();

        $('select').material_select();

        $('.tooltipped').tooltip({ delay: 50 });

        pageDrink.selecSizetDrinks();

        pageDrink.selecTypetDrinks();

        pageDrink.GetNumberOfDrinksByType();

        setTimeout(function () { pageDrink.selectAllDrinks(); pageDrink.GetNumberOfDrinksByType(); }, 300);

        $("#pictureinput").bind("change", function () { pageDrink.getPictureToBase64() });

    }

};

$(document).ready(function () {

    pageDrink.init();

    var $DrinkPicture;

});
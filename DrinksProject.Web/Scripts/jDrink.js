window.pageDrink = {


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

    selectAllDrinks: function () {
        $.ajax({

            url: 'api/Drink/SelectAllDrinks',
            type: 'POST',
            dataType: 'json',
            success: function (data) {

                $('#drinkTable').DataTable({
                    data: data,
                    columns: [
                        { data: 'NAME' },
                        { data: 'TYPENAME' },
                        { data: 'SIZENAME' }
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
                "FK_TYPE": $('#typedrinkselect').val()
            },
            success: function (e) {
                
            }

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

        pageDrink.selecSizetDrinks();

        pageDrink.selecTypetDrinks();

        setTimeout(function () { pageDrink.selectAllDrinks(); }, 300);

        $("#pictureinput").bind("change", function () { pageDrink.getPictureToBase64() });

    }

};

$(document).ready(function () {

    pageDrink.init();

    var $DrinkPicture;

});
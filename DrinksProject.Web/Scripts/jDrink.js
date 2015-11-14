window.pageDrink = {

    selectDrinks : function () {
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

    events: function () {



    },

    config: function () {

        pageDrink.events();

    },

    init: function () {

        pageDrink.config();

        $('select').material_select();

        pageDrink.selectDrinks();


    }

};

$(document).ready(function () {

    pageDrink.init();

});
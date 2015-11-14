window.pageDrink = {

    createDrink : function ()
    {
        $.ajax({

            url: 'api/Size/SelectAllSizes',
            type: 'POST',
            dataType: 'json',
            success: function (e) {

            }

        });
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

    }

};

$(document).ready(function () {
    
    pageDrink.init();

});
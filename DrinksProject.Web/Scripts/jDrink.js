window.pageDrink = {


    events: function () {
        

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
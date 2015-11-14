window.home = {
    
    events: function () {

    },

    init: function () {
        $(".button-collapse").sideNav();
        $('.parallax').parallax();
    }

}

$(document).ready(function () { home.init(); });
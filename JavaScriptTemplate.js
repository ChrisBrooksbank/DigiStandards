GEO = GEO || {};

GEO.Navigation = (function () {
    "use strict";

    function init() {
        var $navigation = $(".page-election-navigation");
        $navigation.find("select").niceSelect();

        $(".navbar-toggle").click(function() {
             $navigation.slideToggle();
        });
    }

    return {
        init: init
    }
}());

$(document).ready(function () {
    "use strict";
    GEO.Navigation.init();
});
## JavaScript
* Consider appropiate plugins depending on project/techs 
	* e.g. NiceSelect which makes a select list look like a animated dropdown menu


```javascript
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
```

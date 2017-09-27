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


JQuery objects names to be prefixed with $, so reader knows they have JQuery functions available

To ensure text in HTML is encoded correctly, use the text property

e.g.
```javascript
var $memberColumn = $("<td/>").text(memberNameToAdd);
var $memberIdColumn = $("<td/>").text(memberIdToAdd);
var $newRow = $("<tr/>").append($memberColumn).append($memberIdColumn);

 $('table.photobookmembers tr:last').after($newRow);
```

When writing a JS function, ensure it could be used if multiple of same component are on page, parametise as needed
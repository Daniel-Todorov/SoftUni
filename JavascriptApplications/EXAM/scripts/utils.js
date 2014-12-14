"use strict";

var app = { };

app.utils = (function () {

    function displaySection($sectionToDisplay) {
        var $sections = $('section');

        $sections.hide();
        $sectionToDisplay.show();
    }

    function isDefined(variable) {
        if((typeof variable).toLowerCase() === 'undefined') {
            return false;
        } else {
            return true;
        }
    }

    return {
        displaySection: displaySection,
        isDefined: isDefined
    }
}());
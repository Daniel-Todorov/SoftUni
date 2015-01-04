'use strict';

app.filter('transformDate', function () {
    var months = [
        'Jan',
        'Feb',
        'Mar',
        'Apr',
        'May',
        'Jun',
        'Jul',
        'Aug',
        'Sep',
        'Oct',
        'Nov',
        'Dec'
    ]

    return    function (date) {
        var milliseconds = Date.parse(date),
            parsedDate = new Date(milliseconds),
            date = parsedDate.getDate(),
            month = months[parsedDate.getMonth()],
            year = parsedDate.getFullYear(),
            modifiedDate = date + '-' + month + '-' + year;

        return modifiedDate;
    };
});
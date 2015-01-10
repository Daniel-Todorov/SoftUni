'use strict';

app.filter('transformStatus', function () {
    var statuses = {
        'Inactive': 'Inactive',
        'WaitingApproval': 'Waiting Approval',
        'Published': 'Published'
    };

    return    function (statusId) {
        return statuses[statusId];
    };
});
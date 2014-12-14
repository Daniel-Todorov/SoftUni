"use strict";

app.notificationsController = (function () {
    var _$notificationPanel;

    function showNotification(message, isSuccess) {

        if (!app.utils.isDefined(_$notificationPanel)) {
            _$notificationPanel = $(document.createElement('div'));
            _$notificationPanel.addClass('notification-panel');
            $('body').append(_$notificationPanel);
        }

        if (isSuccess) {
            _$notificationPanel.removeClass('error');
            _$notificationPanel.addClass('success');
        } else {
            _$notificationPanel.removeClass('success');
            _$notificationPanel.addClass('error');
        }

        _$notificationPanel.text(message);

        _$notificationPanel.show();

        setTimeout(function () {
            _$notificationPanel.hide();
        }, 2000)
    }

    return {
        showNotification: showNotification
    }
}());
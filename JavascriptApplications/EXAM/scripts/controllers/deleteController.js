"use strict";

app.deleteController = (function () {
    var _deleteViewSelector = '.delete-view',
        _$deleteView,
        _productInfo;

    function initialize(productInfo) {
        _productInfo = productInfo;

        if (!app.utils.isDefined(_$deleteView)) {
            _$deleteView = $(_deleteViewSelector);

            _$deleteView.on('click', '#delete-product-button', deleteProduct);

            _$deleteView.on('click', '#cancel-button', function (event) {
                event.preventDefault();

                console.log('going to products view');
                app.productsController.initialize();
            });
        }

        app.utils.displaySection(_$deleteView);

        setProductData();
    }

    function deleteProduct(event) {
        event.preventDefault();

        var currentUser = app.userSession.getCurrentUser(),
            sessionToken = currentUser.sessionToken;

        app.ajaxRequester.deleteProduct(sessionToken, _productInfo.objectId, deleteSuccess, deleteError);
    }

    function deleteSuccess(data) {
        app.notificationsController.showNotification('The product was successfully deleted!', true);

        console.log('going to product view');
        app.productsController.initialize();
    }

    function deleteError(error) {
        console.log('Deleting product error: ' + error.responseText);

        app.notificationsController.showNotification('Deleting the product failed! Please, check console for more information.', false);
    }

    function setProductData() {
        _$deleteView.find('#name').val(_productInfo.name);
        _$deleteView.find('#category').val(_productInfo.category);
        _$deleteView.find('#price').val(_productInfo.price);
    }

    return {
        initialize: initialize
    }
}());
"use strict";

app.editController = (function () {
    var _editViewSelector = '.edit-view',
        _$editView,
        _productInfo;

    function initialize(productInfo) {
        _productInfo = productInfo;

        if (!app.utils.isDefined(_$editView)) {
            _$editView = $(_editViewSelector);

            _$editView.on('click', '#edit-product-button', editProduct);

            _$editView.on('click', '#cancel-button', function (event) {
                event.preventDefault();

                console.log('going to products view');
                app.productsController.initialize();
            });
        }

        app.utils.displaySection(_$editView);

        setProductData();
    }

    function editProduct(event) {
        event.preventDefault();

        var currentUser = app.userSession.getCurrentUser(),
            sessionToken = currentUser.sessionToken,
            newName = _$editView.find('#name').val(),
            newCategory = _$editView.find('#category').val(),
            newPrice = parseFloat(_$editView.find('#price').val());

        app.ajaxRequester.editProduct(sessionToken, newName, newCategory, newPrice, _productInfo.objectId, currentUser.objectId, editSuccess, editError);
    }

    function editSuccess(data) {
        app.notificationsController.showNotification('The product was successfully edited!', true);

        console.log('going to product view');
        app.productsController.initialize();
    }

    function editError(error) {
        console.log('Editing product error: ' + error.responseText);

        app.notificationsController.showNotification('Editing the product failed! Please, check console for more information.', false);
    }

    function setProductData() {
        _$editView.find('#name').val(_productInfo.name);
        _$editView.find('#category').val(_productInfo.category);
        _$editView.find('#price').val(_productInfo.price);
    }

    return {
        initialize: initialize
    }
}());
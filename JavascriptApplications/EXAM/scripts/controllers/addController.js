"use strict";

app.addController = (function () {
    var _addViewSelector = '.add-view',
        _addFormSelector = '.add-product-form',
        _$addView,
        _$addForm;

    function initialize() {

        if (!app.utils.isDefined(_$addView) || !app.utils.isDefined(_$addForm)) {
            _$addView = $(_addViewSelector);
            _$addForm = $(_addFormSelector);

            _$addForm.on('click', '#add-product-button', function (event) {
                event.preventDefault();

                addProduct();
            });

            _$addForm.on('click', '#cancel-button', function (event) {
                event.preventDefault();

                console.log('going to products view');
                app.productsController.initialize();
            })
        }

        app.utils.displaySection(_$addView);
    }

    function addProduct() {
        var $nameInput = _$addForm.find('#name'),
            name = $nameInput.val(),
            $categoryInput = _$addForm.find('#category'),
            category = $categoryInput.val(),
            $priceInput = _$addForm.find('#price'),
            price = parseFloat($priceInput.val()),
            currentUser = app.userSession.getCurrentUser();

        app.ajaxRequester.createProduct(name, category, price, currentUser.objectId, addSuccess, addError);
    }

    function addSuccess(data) {
        _$addForm.find('input').val('');

        console.log('going to products');
        app.productsController.initialize();
        app.notificationsController.showNotification('Product added!', true)
    }

    function addError(error) {
        console.log('Adding product error: ' + error.responseText);
        app.notificationsController.showNotification('Adding product failed! Please, try again and check the console for more details.', false)
    }

    return {
        initialize: initialize
    }
}());
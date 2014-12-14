"use strict";

app.productsController = (function () {
    var _productsViewSelector = '.products-view',
        _productsContainerSelector = '.products > ul',
        _$productsView,
        _$productsContainer;

    function initialize() {
        var currentUser = app.userSession.getCurrentUser(),
            sessionToken = currentUser.sessionToken;

        if (!app.utils.isDefined(_$productsView) || !app.utils.isDefined(_$productsContainer)) {
            _$productsView = $(_productsViewSelector);
            _$productsContainer = $(_productsContainerSelector);
        }

        app.utils.displaySection(_$productsView);

        _$productsContainer.html('');

        app.ajaxRequester.getProducts(sessionToken, getProductsSuccess, getProductsError);
    }

    function getProductsSuccess(data) {
        var products = data.results,
            numberOfProducts = products.length,
            currentUserId = app.userSession.getCurrentUser().objectId,
            $newProduct,
            $productTemplate = $('<li class="product"><div class="product-info"><p class="item-name"></p><p class="category"><span class="pre">Category:</span><span class="category-value"></span></p><p class="price"><span class="pre">Price:</span> $<span class="price-value"></span></p></div><footer class="product-footer"><a href="#"><button class="edit-button">Edit</button></a><a href="#"><button class="delete-button">Delete</button></a></footer></li>');

        for (var i = 0; i < numberOfProducts; i++){
            $newProduct = $productTemplate.clone();

            $newProduct.find('.item-name').text(products[i].name);
            $newProduct.find('.category-value').text(products[i].category);
            $newProduct.find('.price-value').text(products[i].price);
            $newProduct.find('.product-footer').data('productInfo' , products[i]);

            if (currentUserId != products[i].userId) {
                $newProduct.find('.product-footer').html('');
            }

            _$productsContainer.append($newProduct);
        }

        _$productsContainer.on('click', '.edit-button', editAction);
        _$productsContainer.on('click', '.delete-button', deleteAction);
    }

    function deleteAction(event) {
        event.preventDefault();

        var productInfo = $(event.target).parents('.product-footer').data().productInfo;

        console.log('going to delete product');
        app.deleteController.initialize(productInfo);
    }

    function editAction(event) {
        event.preventDefault();

        var productInfo = $(event.target).parents('.product-footer').data().productInfo;

        console.log('going to edit product');
        app.editController.initialize(productInfo);
    }

    function getProductsError(error) {
        console.log(error.responseText)

        app.notificationsController.showNotification('An error occurred while trying to fetch the products! Please, check the cnsole formore information.');
    }

    return {
        initialize: initialize
    }
}());
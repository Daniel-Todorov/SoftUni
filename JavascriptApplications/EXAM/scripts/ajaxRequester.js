'use strict';

app.ajaxRequester = (function() {
    var baseUrl = "https://api.parse.com/1/";

    var headers =
    {
        "X-Parse-Application-Id": "H9NVzgWSH4ROuKADaBSVMCatjlTprpH7Hxs8XyNa",
        "X-Parse-REST-API-Key": "E43w8lNtGIFzqPtJEmWwUY9L961pFgLfcCfhAk1r"
    };

    function login(username, password, success, error) {
        jQuery.ajax({
            method: "GET",
            headers: headers,
            url: baseUrl + "login",
            data: {username: username, password: password},
            success: success,
            error: error
        });
    }

    function register(username, password, success, error) {
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "users",
            data: JSON.stringify({username: username, password: password}),
            success: success,
            error: error
        });
    }

    function getHeadersWithSessionToken(sessionToken) {
        var headersWithToken = JSON.parse(JSON.stringify(headers));
        headersWithToken['X-Parse-Session-Token'] = sessionToken;
        return headersWithToken;
    }

    function getProducts(sessionToken, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "GET",
            headers: headersWithToken,
            url: baseUrl + "classes/product",
            success: success,
            error: error
        });
    }

    function createProduct(name, category, price, userId, success, error) {
        var product = {name: name, userId: userId, category: category, price: price, ACL : {}};
        product.ACL[userId] = {"write": true, "read": true};
        product.ACL["*"] = {"read":true};
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "classes/product",
            data: JSON.stringify(product),
            success: success,
            error: error
        });
    }

    function deleteProduct(sessionToken, productId, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "DELETE",
            headers: headersWithToken,
            url: baseUrl + "classes/product/" + productId,
            success: success,
            error: error
        });
    }

    function editProduct(sessionToken, name, category, price, productId, userId, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        var product = {name: name, category: category, price: price, ACL : {}};
        product.ACL[userId] = {"write": true, "read": true};
        product.ACL["*"] = {"read":true};
        jQuery.ajax({
            method: "PUT",
            headers: headersWithToken,
            url: baseUrl + "classes/product/" + productId,
            data: JSON.stringify(product),
            success: success,
            error: error
        });
    }

    return {
        login: login,
        register: register,
        getProducts: getProducts,
        createProduct: createProduct,
        editProduct: editProduct,
        deleteProduct: deleteProduct
    };
})();
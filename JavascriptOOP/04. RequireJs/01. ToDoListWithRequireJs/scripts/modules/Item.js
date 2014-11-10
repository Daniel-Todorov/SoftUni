define(function () {
	function Item(content) {
		this._content;
		this._status = false;
		this.setContent(content);
	}

	Item.prototype.setContent = function (content) {
		if ((typeof content).toLowerCase() !== 'string' || content.length <= 0) {
			throw 'Content must be a string and cannot be empty.';
		}

		this._content = content;
	};

	Item.prototype.getContent = function () {
		return this._content;
	};

	Item.prototype.setStatus = function (status) {
		if ((typeof status).toLowerCase() !== 'boolean') {
			throw 'Status of item can be only of boolean type.';
		}

		this._status = status;
	};

	Item.prototype.getStatus = function () {
		return this._status;
	};

	Item.prototype.addToDOM = function (container) {
		if (container === null) {
			throw 'Container can\'t be null';
		}

		try {
			var itemBody = document.createElement('li');
			var innerBody = document.createElement('div');
			var statusBody = document.createElement('input');
			var contentBody = document.createElement('p');

			contentBody.innerText = this.getContent();
			statusBody.setAttribute('type', 'checkbox');
			if (this.getStatus()) {
				statusBody.setAttribute('checked', 'checked');
			}

			innerBody.appendChild(statusBody);
			innerBody.appendChild(contentBody);
			itemBody.appendChild(innerBody);
			container.appendChild(itemBody);
		} catch (e) {
			console.log('Adding item to DOM failed.' + e);
		}
	};

	return Item;
})
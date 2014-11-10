define(function () {
	function Section(title) {
		this._title;
		this._items = [];
		this.setTitle(title);
	}

	Section.prototype.setTitle = function (title) {
		if ((typeof title).toLowerCase() !== 'string' || title.length <= 0) {
			throw 'Content must be a string and cannot be empty.';
		}

		this._title = title;
	};

	Section.prototype.getTitle = function () {
		return this._title;
	};

	Section.prototype.addItem = function (item) {
		if (!(item instanceof Item)) {
			throw 'Section items must be of type Item';
		}

		this._items.push(item);
	};

	Section.prototype.getItems = function () {
		return this._items;
	};

	Section.prototype.addToDOM = function (container) {
		if (container === null) {
			throw 'Container can\'t be null';
		}

		try {
			var sectionBody = document.createElement('div');
			var sectionInnerBody = document.createElement('ul');
			var sectionTitle = document.createElement('h2');
			var sectionAddInput = document.createElement('input');
			var sectionAddButton = document.createElement('button');

			sectionBody.setAttribute('class', 'section');
			sectionTitle.innerText = this.getTitle();
			sectionAddInput.setAttribute('type', 'text');
			sectionAddInput.setAttribute('placeholder', 'Add Item...');
			sectionAddButton.innerHTML = '+';
			sectionAddButton.setAttribute('class', 'add-item-button');

			sectionInnerBody.appendChild(sectionTitle);
			var items = this.getItems();
			for (var i = 0; i < items.length; i++) {
				items[i].addToDOM(sectionInnerBody);
			}
			sectionBody.appendChild(sectionInnerBody);
			sectionBody.appendChild(sectionAddInput);
			sectionBody.appendChild(sectionAddButton);
			container.appendChild(sectionBody);
		} catch (e) {
			console.log('Adding section to DOM failed.' + e);
		}
	};

	return Section;
})
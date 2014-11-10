'use strict';

var ToDoModule = (function () {
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
//			statusBody.setAttribute('checked', this.getStatus() ? 'checked' : '');

			innerBody.appendChild(statusBody);
			innerBody.appendChild(contentBody);
			itemBody.appendChild(innerBody);
			container.appendChild(itemBody);
		} catch (e) {
			console.log('Adding item to DOM failed.' + e);
		}
	};

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

	function Container() {
		this._sections = [];
	}

	Container.prototype.addSection = function (section) {
		if (!(section instanceof Section)) {
			throw 'Sections in Container must be instances of Section';
		}

		this._sections.push(section);
	};

	Container.prototype.getSections = function () {
		return this._sections;
	};

	Container.prototype.addToDOM = function (container) {
		if (container === null) {
			throw 'Container can\'t be null';
		}

		try {
			var containerBody = document.createElement('div');
			var containerTitle = document.createElement('h1');
			var containerAddInput = document.createElement('input');
			var containerAddButton = document.createElement('button');

			containerBody.setAttribute('class', 'container');
			containerTitle.innerText = 'ToDo List';
			containerAddInput.setAttribute('type', 'text');
			containerAddInput.setAttribute('placeholder', 'Title');
			containerAddInput.setAttribute('class', 'new-section-title');
			containerAddButton.innerHTML = 'New section';
			containerAddButton.setAttribute('class', 'add-section-button');

			containerBody.appendChild(containerTitle);
			var sections = this.getSections();
			for (var i = 0; i < sections.length; i++) {
				sections[i].addToDOM(containerBody);
			}
			containerBody.appendChild(containerAddInput);
			containerBody.appendChild(containerAddButton);
			container.appendChild(containerBody);
		} catch (e) {
			console.log('Adding container to DOM failed.' + e);
		}
	};

	return{
		Item: Item,
		Section: Section,
		Container: Container
	};
})();

var container = new ToDoModule.Container();
container.addToDOM(document.body);

var addSectionButtons = document.getElementsByClassName('add-section-button');
bindEvent(addSectionButtons, 'click', addNewSectionEvent);

function addNewSectionEvent(event) {
	event.preventDefault();

	var titleInput = event.target.parentNode.querySelector('.new-section-title');
	var sectionTitle = titleInput.value;
	titleInput.value = '';
	var newSection = new ToDoModule.Section(sectionTitle);
	newSection.addToDOM(event.target.parentNode);

	var addItemButtons = document.getElementsByClassName('add-item-button');
	bindEvent(addItemButtons, 'click', addNewItemEvent);
}

function addNewItemEvent(event) {
	event.preventDefault();

	var contentInput = event.target.parentNode.querySelector('input[type=text]');
	var itemContent = contentInput.value;
	contentInput.value = '';
	var newItem = new ToDoModule.Item(itemContent);
	newItem.addToDOM(event.target.parentNode.querySelector('ul'));

	var checkboxes = document.body.querySelectorAll('input[type=checkbox]');
	bindEvent(checkboxes, 'change', changeColor);
}

function changeColor(event){
	var parentElement = event.target.parentNode;

	if (event.target.checked) {
		parentElement.style.backgroundColor = 'green';
	} else {
		parentElement.style.backgroundColor = 'white';
	}
}

function bindEvent(elements, eventType, eventFunction) {
	for (var i = 0; i < elements.length; i++) {
		elements[i].addEventListener(eventType, eventFunction);
	}
}
define(function () {
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

	return Container;
})
(function () {
	require(['modules/Factory'], function (Factory) {
		var container = new Factory.Container();
		container.addToDOM(document.body);

		var addSectionButtons = document.getElementsByClassName('add-section-button');
		bindEvent(addSectionButtons, 'click', addNewSectionEvent);

		function addNewSectionEvent(event) {
			event.preventDefault();

			var titleInput = event.target.parentNode.querySelector('.new-section-title');
			var sectionTitle = titleInput.value;
			titleInput.value = '';
			var newSection = new Factory.Section(sectionTitle);
			newSection.addToDOM(event.target.parentNode);

			var addItemButtons = document.getElementsByClassName('add-item-button');
			bindEvent(addItemButtons, 'click', addNewItemEvent);
		}

		function addNewItemEvent(event) {
			event.preventDefault();

			var contentInput = event.target.parentNode.querySelector('input[type=text]');
			var itemContent = contentInput.value;
			contentInput.value = '';
			var newItem = new Factory.Item(itemContent);
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
	});
}());


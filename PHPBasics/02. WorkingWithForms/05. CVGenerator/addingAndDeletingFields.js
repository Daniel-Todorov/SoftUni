$(function () {
    $('#removeComputerLanguage').on('click', function (event) {
        event.preventDefault();

        $('.computerLanguages input')
            .last()
            .remove();

        $('.computerLanguages select')
            .last()
            .remove();

        $('.computerLanguages br')
            .last()
            .remove();
    });

    $('#addComputerLanguage').on('click', function (event) {
        event.preventDefault();

        $container = $('.computerLanguages');
        $input = $('<input type="text" name="computerLanguages[]">');
        $select = $('<select name="computerLanguageProficiences[]"><option value="Beginner">Beginner</option><option value="Programmer">Programmer</option><option value="Ninja">Ninja</option></select>');
        $break = $('<br>');

        $container.append($input);
        $container.append($select);
        $container.append($break);
    });

    $('#removeLanguage').on('click', function (event) {
        event.preventDefault();

        $('.languages input[type=text]')
            .last()
            .remove();

        $('.languages select[name="languageComprehensions[]"]')
            .last()
            .remove();

        $('.languages select[name="languageReadings[]"]')
            .last()
            .remove();

        $('.languages select[name="languageWritings[]"]')
            .last()
            .remove();

        $('.languages br')
            .last()
            .remove();
    });

    $('#addLanguage').on('click', function (event) {
        event.preventDefault();

        $container = $('.languages');
        $input = $('<input type="text" name="languages[]">');
        $selectCompehension = $('<select name="languageComprehensions[]"><option selected disabled>-Comprehension-</option><option value="beginner">beginner</option><option value="intermediate">intermediate</option><option value="advanced">advanced</option></select>');
        $selectReading = $('<select name="languageReadings[]"><option selected disabled>-Reading-</option><option value="beginner">beginner</option><option value="intermediate">intermediate</option><option value="advanced">advanced</option></select>');
        $selectWriting = $('<select name="languageWritings[]"><option selected disabled>-Writing-</option><option value="beginner">beginner</option><option value="intermediate">intermediate</option><option value="advanced">advanced</option></select>');
        $break = $('<br>');

        $container.append($input);
        $container.append($selectCompehension);
        $container.append($selectReading);
        $container.append($selectWriting);
        $container.append($break);
    });
});
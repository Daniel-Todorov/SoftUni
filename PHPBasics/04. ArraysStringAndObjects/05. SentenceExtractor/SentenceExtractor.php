<!--Write a PHP program SentenceExtractor.php that takes a text from a textarea -->
<!--and a word from an input field and prints all sentences from the text, containing that word. -->
<!--A sentence is any sequence of words ending with ., ! or ?.-->

<!DOCTYPE html>
<html>
<head>
    <title>Sentence Extractor</title>
</head>
<body>
<section>
    <form method="post">
        <label for="text">Enter text here:</label>
        <br>
        <textarea cols="20" rows="10" name="text" id="text"></textarea>
        <br>
        <label for="word">Enter word here:</label>
        <br>
        <input type="text" name="word" id="word">
        <br>
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['text']) && isset($_POST['word'])) {
    $text = $_POST['text'];
    $word = $_POST['word'];
    $sentences = preg_split("/\.|!|\?/", $text);
    ?>
    <section>
        <?php
        foreach ($sentences as $sentence) {
            if (preg_match("/\sis\s/", $sentence)) {
                echo "<p>{$sentence}</p>";
            }
        }
        ?>
    </section>
<?php
}
?>
</body>
</html>
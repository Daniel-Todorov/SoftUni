<!--Write a PHP program TextFilter.php that takes a text from a textfield -->
<!--and a string of banned words from a text input field. -->
<!--All words included in the ban list should be replaced with asterisks "*", equal to the word’s length. -->
<!--The entries in the banlist will be separated by a comma and space ", ".-->

<!DOCTYPE html>
<html>
<head>
    <title>Text Filter</title>
</head>
<body>
<section>
    <form method="post">
        <label for="text">Add text here:</label>
        <br>
        <textarea cols="20" rows="10" name="text" id="text"></textarea>
        <br>
        <label for="bannedWords">Add banned words here:</label>
        <br>
        <input type="text" name="bannedWords" id="bannedWords">
        <br>
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['text']) && isset($_POST['bannedWords'])) {
    $text = $_POST['text'];
    $editedText = $text;
    $bannedWords = mb_split(", ", $_POST['bannedWords']);
    $resultInput = "";

    foreach ($bannedWords as $bannedWord) {
        $lengthOfBannedWord = mb_strlen($bannedWord);
        $replacementString = str_repeat("*", $lengthOfBannedWord);
        $editedText = str_replace($bannedWord, $replacementString, $editedText);
    }
    ?>
    <section>
        <p><?= $editedText ?></p>
    </section>
<?php
}
?>
</body>
</html>
<!--Write a PHP program WordMapper.php that takes a text from a textarea and prints each word -->
<!--and the number of times it occurs in the text. -->
<!--The search should be case-insensitive. -->
<!--The result should be printed as an HTML table.-->

<!DOCTYPE html>
<html>
<head>
    <title>Word Mapping</title>
</head>
<body>
<section>
    <form method="post">
        <textarea name="text"></textarea>
        <input type="submit" value="Count words">
    </form>
</section>
<?php
if (isset($_POST['text']) && !empty($_POST['text'])) {
    $text = $_POST['text'];
    $normalizedText = mb_strtolower($text);

    preg_match_all("/\w+/", $normalizedText, $matches);
    $words = $matches[0];
    $wordCounter = [];

    foreach ($words as $word) {
        if (isset($wordCounter[$word])) {
            $wordCounter[$word]++;
        } else {
            $wordCounter[$word] = 1;
        }
    }
    ?>
    <section>
        <table border="1">
            <tbody>
            <?php
            foreach ($wordCounter as $wordValue => $numberOfOccurences) {
                echo "<tr>";
                echo "<td>{$wordValue}</td>";
                echo "<td>{$numberOfOccurences}</td>";
                echo "</tr>";
            }
            ?>
            </tbody>
        </table>
    </section>
<?php
}
?>
</body>
</html>
<!--Write a PHP program URLReplacer.php that takes a text from a textarea -->
<!--and replaces all URLs with the HTML syntax <a href= "…" ></a> -->
<!--with a special forum-style syntax [URL=…][/URL].-->

<!DOCTYPE html>
<html>
<head>
    <title>URL Replacer</title>
</head>
<body>
<section>
    <form method="post">
        <label for="text">Enter text here:</label>
        <br>
        <textarea id="text" name="text" cols="30" rows="15"></textarea>
        <br>
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['text'])) {
    $text = $_POST['text'];
    $resultToPrint = str_replace("</a>", "[/URL]", $text);
    $resultToPrint = str_replace("<a href=\"", "[URL=", $resultToPrint);
    $resultToPrint = str_replace("\">", "]", $resultToPrint);

    $resultToPrint = htmlentities($resultToPrint);
    ?>
    <section>
        <p><?= $resultToPrint ?></p>
    </section>
<?php
}
?>
</body>
</html>
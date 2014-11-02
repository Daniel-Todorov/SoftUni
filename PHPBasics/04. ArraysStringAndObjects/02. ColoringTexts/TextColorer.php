<!--Write a PHP program TextColorer.php that takes a text from a textfield, colors -->
<!--each character according to its ASCII value and prints the result. -->
<!--If the ASCII value of a character is odd, the character should be printed in blue. -->
<!--If it’s even, it should be printed in red.-->

<?php
function isEvenNumber($number)
{
    if ($number % 2 === 0) {
        return true;
    } else {
        return false;
    }
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Coloring Texts</title>
</head>
<body>
<section>
    <form method="post">
        <textarea cols="20" rows="10" name="input"></textarea>
        <br>
        <input type="submit" value="Color text">
    </form>
</section>
<?php
if (isset($_POST['input'])) {
    $text = $_POST['input'];
    $charactersInText = str_split($text);
    ?>
    <section>
        <p>
            <?php
            foreach ($charactersInText as $character) {
                $anciiCode = ord($character);
                if (isEvenNumber($anciiCode)) {
                    $color = "red";
                } else {
                    $color = "blue";
                }

                echo "<span style='color: {$color}'>{$character}</span>";
            }
            ?>
        </p>
    </section>
<?php
}
?>
</body>
</html>
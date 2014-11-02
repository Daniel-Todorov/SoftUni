<!--Write a PHP script SumOfDigits.php which receives a comma-separated list of integers -->
<!--from an input form and creates a two-column table. -->
<!--The first column should contain each of the values from the input. -->
<!--The second column should contain the sum of the digits of each value. -->
<!--If the value is not an integer number, print "I cannot sum that". -->
<!--Styling the page is optional.-->

<?php
function isInteger($input)
{
    return (ctype_digit(strval($input)));
}

function sumDigits($number)
{
    $intvalNumber = intval($number);

    if ($intvalNumber < 0) {
        $normalizedNumber = $intvalNumber * -1;
    } else {
        $normalizedNumber = $number;
    }

    $stringifiedNumber = $normalizedNumber . "";
    $numberOfDigits = mb_strlen($stringifiedNumber);
    $sum = 0;

    for ($i = 0; $i < $numberOfDigits; $i++) {
        $sum += intval($stringifiedNumber[$i]);
    }

    return $sum;
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Sum of Digits</title>
</head>
<body>
<section>
    <form method="post">
        <label for="numbers">Input string:</label>
        <input type="text" name="numbers" id="numbers">
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['numbers']) && !empty($_POST['numbers'])) {
    $numbers = explode(", ", $_POST['numbers']);
    ?>
    <section>
        <table border="1">
            <tbody>
            <?php
            foreach ($numbers as $number) {
                echo "<tr>";
                echo "<td>{$number}</td>";
                if (isInteger($number)) {
                    $sumOfDigits = sumDigits($number);
                    echo "<td>{$sumOfDigits}</td>";
                } else {
                    echo "<td>I cannot sum that</td>";
                }
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
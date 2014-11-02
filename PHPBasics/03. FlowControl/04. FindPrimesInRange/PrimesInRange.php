<!--Write a PHP script PrimesInRange.php that receives two numbers – start and end – -->
<!--from an input field and displays all numbers in that range as a comma-separated list. -->
<!--Prime numbers should be bolded. -->
<!--Styling the page is optional.-->

<?php
function isPrime($number)
{
    if ($number <= 3) {
        if ($number <= 1) {
            return false;
        } else {
            return true;
        }
    }

    if ($number % 2 == 0 || $number % 3 == 0) {
        return false;
    }

    for ($i = 5; $i < sqrt($number) + 1; $i += 6) {
        if ($number % $i === 0 || $number % ($i + 2) === 0) {
            return false;
        }
    }

    return true;
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Find Primes in Range</title>
</head>
<body>
<section>
    <form method="post">
        <label for="start">Starting Index:</label>
        <input type="number" name="startIndex" id="start" min="0" step="1">
        <label for="end">End:</label>
        <input type="number" name="endIndex" id="end" min="0" step="1">
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['startIndex']) && isset($_POST['endIndex'])) {
    $startIndex = $_POST['startIndex'];
    $endIndex = $_POST['endIndex'];
    $resultToPrint = "";

    for ($i = $startIndex; $i <= $endIndex; $i++) {
        if (isPrime($i)) {
            $resultToPrint .= "<strong>{$i}</strong>, ";
        } else {
            $resultToPrint .= "{$i}, ";
        }
    }

    $resultToPrint = trim($resultToPrint, ", ")
    ?>
    <section>
        <p><?= $resultToPrint ?></p>
    </section>
<?php
}
?>
</body>
</html>
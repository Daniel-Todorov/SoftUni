<!--Write a PHP script StringModifier.php which receives a string from an input form -->
<!--and modifies it according to the selected option (radio button). -->
<!--You should support the following operations: palindrome check, reverse string, -->
<!--split to extract letters only, hash the string with the default PHP hashing algorithm, -->
<!--shuffle the string characters randomly. -->
<!--The result should be displayed right under the input field. -->
<!--Styling the page is optional. -->
<!--Think about which of the modification can be achieved with already built-in functions in PHP. -->
<!--Where necessary, write your own algorithms to modify the given string. -->
<!--Hint: Use the crypt() function for the "Hash String" modification.-->

<?php
function splitStringInLetters($input)
{
    $normalizedString = preg_replace("/\W/", "", $input);
    $charactersInString = str_split($normalizedString);
    $resultString = implode(" ", $charactersInString);

    return $resultString;
}

function isPalindrome($input)
{
    $reversedInput = strrev($input);
    if ($input === $reversedInput) {
        return true;
    } else {
        return false;
    }
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Modify String</title>
</head>
<body>
<section>
    <form method="post">
        <input type="text" name="input">
        <input type="radio" name="operation" id="palindrome" value="isPalindrome">
        <label for="palindrome">Check Palindrome</label>
        <input type="radio" name="operation" id="reverse" value="reverse">
        <label for="reverse">Reverse String</label>
        <input type="radio" name="operation" id="split" value="split">
        <label for="split">Split</label>
        <input type="radio" name="operation" id="hash" value="hash">
        <label for="hash">Hash String</label>
        <input type="radio" name="operation" id="shuffle" value="shuffle">
        <label for="shuffle">Shuffle String</label>
        <input type="submit">
    </form>
</section>
<?php
if (isset($_POST['input']) && isset($_POST['operation'])) {
    $input = $_POST['input'];
    $operation = $_POST['operation'];
    $resultToPrint = "";

    switch ($operation) {
        case "isPalindrome":
            if (isPalindrome($input)) {
                $resultToPrint = "{$input} is a palindrome!";
            } else {
                $resultToPrint = "{$input} is not a palindrome!";
            }
            break;
        case "reverse":
            $resultToPrint = strrev($input);
            break;
        case "split":
            $resultToPrint = splitStringInLetters($input);
            break;
        case "hash":
            $resultToPrint = crypt($input);
            break;
        case "shuffle":
            $resultToPrint = str_shuffle($input);
            break;
        default:
            break;
    }
    ?>
    <section>
        <p><?= $resultToPrint ?></p>
    </section>
<?php
}
?>
</body>
</html>
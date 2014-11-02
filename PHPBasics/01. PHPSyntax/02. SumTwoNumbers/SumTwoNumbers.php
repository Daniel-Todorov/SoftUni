<?php
/**
 * Write a PHP script SumTwoNumbers.php that decleares two variables, firstNumber and secondNumber.
 * They should hold integer or floating-point numbers (hard-coded values).
 * Print their sum in the output in the format shown in the examples below.
 * The numbers should be rounded to the second number after the decimal point.
 * Find in Internet how to round a given number in PHP.
 */

function sumTwoNumbers($firstNumber, $secondNumber)
{
    $sum = $firstNumber + $secondNumber;
    $roundedSum = round($sum, 2);
    $resultToPrint = "\$firstNumber + \$secondNumber = {$firstNumber} + {$secondNumber} = {$roundedSum}";

    echo $resultToPrint;
}

sumTwoNumbers(2, 5);
echo "<br>";
sumTwoNumbers(1.567808, 0.356);
echo "<br>";
sumTwoNumbers(1234.5678, 333);


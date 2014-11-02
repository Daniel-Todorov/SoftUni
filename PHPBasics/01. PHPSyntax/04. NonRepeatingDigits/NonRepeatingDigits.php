<?php
/**
 * Write a PHP script NonRepeatingDigits.php that declares an integer variable N,
 * and then finds all 3-digit numbers that are less or equal than N (<= N) and consist of unique digits.
 * Print "no" if no such numbers exist.
 */

function getNonrepeatingNumbers($input)
{
    $result = array();

    for ($i = 102; $i <= $input && $i < 989; $i++) {
        $stringifiedNumber = (string)$i;

        if($stringifiedNumber[0] !== $stringifiedNumber[1] && $stringifiedNumber[0] !== $stringifiedNumber[2] && $stringifiedNumber[1] !== $stringifiedNumber[2]){
            array_push($result, $stringifiedNumber);
        }
    }

    if(count($result) > 0){
        echo implode(", ", $result);
    } else {
        echo "no";
    }
}

getNonrepeatingNumbers(1234);
echo "<br><br>";
getNonrepeatingNumbers(145);
echo "<br><br>";
getNonrepeatingNumbers(15);
echo "<br><br>";
getNonrepeatingNumbers(247);
<?php
/**
 * Created by PhpStorm.
 * User: Daniel Todorov
 * Date: 14-8-31
 * Time: 12:37
 */

function moveDown($array, $outerNumber, $innerNumber)
{
    for ($i = $outerNumber - 1; $i > 0; $i--) {

        for ($j = 0; $j < $innerNumber; $j++) {

            if ($array[$i][$j] === " ") {
                $array[$i][$j] = $array[$i - 1][$j];
                $array[$i - 1][$j] = " ";
            }
        }
    }

    return $array;
}

$text = $_GET['text'];

$lineLength = intval($_GET['lineLength']);

//Normalizing the text length
if (strlen($text) % $lineLength !== 0) {
    $numberOfSpacesToAdd = $lineLength - strlen($text) % $lineLength;

    $spacesToAdd = str_repeat(" ", $numberOfSpacesToAdd);
    $normalizedText = $text . $spacesToAdd;
}

$charactersInNormalizedText = str_split($normalizedText);

$numberOfCharacters = count($charactersInNormalizedText);
$numberOfSubarrays = strlen($normalizedText) / $lineLength;

$originalArray = [];

for ($i = 0; $i < $lineLength; $i++) {
    $originalArray[$i] = [];

    for ($j = 0; $j < $numberOfSubarrays; $j++) {
        //echo $charactersInNormalizedText[$i + $j * $lineLength];
        if ($charactersInNormalizedText[$i + $j * $lineLength] !== " ") {
            array_push($originalArray[$i], $charactersInNormalizedText[$i + $j * $lineLength]);
        }
    }
}

for ($i = 0; $i < $lineLength; $i++) {

    while (count($originalArray[$i]) < $numberOfSubarrays) {
        array_unshift($originalArray[$i], " ");
    }

    $originalArray[$i] = array_values($originalArray[$i]);
}

$result = "";

$result .= "<table>";

for ($i = 0; $i < $numberOfSubarrays; $i++) {

    $result .= "<tr>";

    for ($j = 0; $j < $lineLength; $j++) {

        $result .= "<td>" . htmlspecialchars($originalArray[$j][$i]) . "</td>";

    }

    $result .= "</tr>";
}

$result .= "<table>";


echo $result;
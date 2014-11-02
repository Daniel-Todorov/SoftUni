<?php
/**
 * Created by PhpStorm.
 * User: Daniel Todorov
 * Date: 14-8-31
 * Time: 10:31
 */

$list = $_GET['list'];
$maxSixe = $_GET['maxSize'];

$linesInList = explode(PHP_EOL, $list);

$result = "";

$result .= "<ul>";

foreach ($linesInList as $line) {
    $trimmedLine = trim($line);
    $lengthOfTrimmedLine = strlen($trimmedLine);
    if ($lengthOfTrimmedLine > 0) {
        if ($lengthOfTrimmedLine <= $maxSixe) {
            $result .= ("<li>" . htmlspecialchars($trimmedLine) . "</li>");
        } else {
            $result .= ("<li>" . htmlspecialchars(substr($trimmedLine, 0, $maxSixe)) . "...</li>");
        }
    }
}

$result .= "</ul>";

echo $result;

?>

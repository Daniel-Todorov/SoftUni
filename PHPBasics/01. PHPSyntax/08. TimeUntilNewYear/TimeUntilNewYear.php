<?php
/**
 * Write a PHP script TimeUntilNewYear.php. Use the built-in function getdate() to get the current date and time.
 * Print how many hours, minutes and seconds are left until New Year
 * and how many days, hours, minutes and seconds are left in a counter format .
 * Look at examples below to get a better idea.
 * The examples show the current date and time in "d-m-Y G:i:s" format.
 * Use the current time.
 */

$currentDate = getdate();
$currentYear = $currentDate['year'];
$nextYear = $currentYear + 1;
$newYearDate = strtotime("01-01-{$nextYear} 00:00:00");
$secondsTillNewYear = $newYearDate - $currentDate[0];
$minutesTillNewYear = floor($secondsTillNewYear / 60);
$hoursTillNewYear = floor($secondsTillNewYear / 3600);
$daysTillNewYear = floor($secondsTillNewYear / 86400);

$finalResult = "{$daysTillNewYear}:"
    . (sprintf("%02d",floor(($secondsTillNewYear - $daysTillNewYear * 86400) / 3600)))
    . ":"
    . (sprintf("%02d",floor(($secondsTillNewYear - $hoursTillNewYear * 3600) / 60)))
    . ":"
    . (sprintf("%02d",floor(($secondsTillNewYear - $minutesTillNewYear * 60))));

echo "Hours until new year : {$hoursTillNewYear}<br>"
."Minutes until new year : {$minutesTillNewYear}<br>"
."Seconds until new year : {$secondsTillNewYear}<br>"
."Days:Hours:Minutes:Seconds {$finalResult}";

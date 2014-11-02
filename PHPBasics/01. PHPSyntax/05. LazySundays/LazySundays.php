<?php
/**
 * Write a PHP script LazySundays.php which prints the dates of all Sundays in the current month.
 */

function getCertainDaysOfWeek($codeOfDayWanted){
    $currentDate = new DateTime("now");
    $currentMonth = $currentDate->format("m");
    $currentYear = $currentDate->format("Y");
    $initialDateInMonth = new DateTime("01-{$currentMonth}-{$currentYear}");
    $currentDateInMonth = $initialDateInMonth;
    $oneDayInterval = new DateInterval('P1D');


    while ($currentDateInMonth->format('m') === $currentMonth){
        if($currentDateInMonth->format('D') === $codeOfDayWanted){
            echo $currentDateInMonth->format('d-m-Y');
            echo "<br>";
        }

        $currentDateInMonth->add($oneDayInterval);
    }
}

getCertainDaysOfWeek("Sun");
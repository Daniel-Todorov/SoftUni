<!--Write a PHP script AwesomeCalendar.php which creates a calendar in HTML for a given year. -->
<!--Styling the calendar is optional. -->
<!--Semantic HTML is required. -->
<!--Hint: Embed HTML in your PHP code. -->
<!--Use tables or divs for structuring the calendar. -->
<!--Look for a way to find the day of the week.-->

<?php
$currentDate = getdate();
$currentYear = $currentDate['year'];
$initialDateTimespan = strtotime("01-01-{$currentYear}");
$loopingDateTimespan = $initialDateTimespan;
$loopingDate = getdate($initialDateTimespan);

while ($loopingDate['year'] === $currentYear) {
    $assossiativeCalendarArray[$currentYear][$loopingDate['month']][$loopingDate['mday']] = $loopingDate['weekday'];
    $loopingDateTimespan = $loopingDateTimespan + 86400;
    $loopingDate = getdate($loopingDateTimespan);
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Awesome Calendar</title>
</head>
<body>
<?php
foreach ($assossiativeCalendarArray as $year => $months) {
    ?>
    <table border="1">
        <thead>
        <tr>
            <th><?php echo $year; ?></th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td>
                <?php
                foreach ($months as $monthName => $monthDays) {
                    ?>
                    <table border="1">
                        <thead>
                        <tr>
                            <th colspan="7"><?php echo $monthName; ?></th>
                        </tr>
                        <tr>
                            <th>Mo</th>
                            <th>Tu</th>
                            <th>We</th>
                            <th>Th</th>
                            <th>Fr</th>
                            <th>Sa</th>
                            <th>Su</th>
                        </tr>
                        </thead>
                        <tbody>
                        <?php
                        echo "<tr>";
                        foreach ($monthDays as $dayNumber => $dayName) {
                            if ($dayNumber == 1) {
                                if ($dayName === "Sunday") {
                                    echo "<td></td><td></td><td></td><td></td><td></td><td></td>";
                                } else if ($dayName === "Saturday") {
                                    echo "<td></td><td></td><td></td><td></td><td></td>";
                                } else if ($dayName === "Friday") {
                                    echo "<td></td><td></td><td></td><td></td>";
                                } else if ($dayName === "Thursday") {
                                    echo "<td></td><td></td><td></td>";
                                } else if ($dayName === "Wednesday") {
                                    echo "<td></td><td></td>";
                                } else if ($dayName === "Tuesday") {
                                    echo "<td></td>";
                                }
                            }

                            echo "<td>{$dayNumber}</td>";

                            if ($dayName === "Sunday") {
                                echo "</tr><tr>";
                            }
                        }
                        echo "</tr>";
                        ?>
                        </tbody>
                    </table>
                <?php
                }
                ?>
            </td>
        </tr>
        </tbody>
    </table>
<?php
}
?>
</body>
</html>
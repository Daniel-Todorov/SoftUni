<!--Write a PHP script AnnualExpenses.php that receives n years from an input HTML form -->
<!--and creates a table (like the one shown below) with random expenses by months -->
<!--and the corresponding years (n years back). -->
<!--For example, if N is 10, create a table that shows the expenses for each month for the last 10 years. -->
<!--Add a "Total" column at the end, showing the total expenses for the same year. -->
<!--The random expenses in the table should be in the range [0…999]. -->
<!--Styling the page is optional.-->

<?php
$currentYear = intval(date("Y"));
$minimalExpenses = 0;
$maxsimalExpenses = 999;
?>

<!DOCTYPE html>
<html>
<head>
    <title>Show Annual Expenses</title>
</head>
<body>
<section>
    <form method="post">
        <label for="years">Enter number of years:</label>
        <input type="number" value="0" name="numberOfYears" id="years" min="0">
        <input type="submit" value="Show cost">
    </form>
</section>
<?php
if (isset($_POST['numberOfYears']) && !empty($_POST['numberOfYears'])) {
    ?>
    <section>
        <table border="1">
            <thead>
            <tr>
                <th>Year</th>
                <th>January</th>
                <th>February</th>
                <th>March</th>
                <th>April</th>
                <th>May</th>
                <th>June</th>
                <th>July</th>
                <th>August</th>
                <th>September</th>
                <th>October</th>
                <th>November</th>
                <th>December</th>
                <th>Total:</th>
            </tr>
            </thead>
            <tbody>
            <?php
            $numberOfYearsBack = intval($_POST['numberOfYears']);
            $earliestYear = $currentYear - $numberOfYearsBack;
            $numberOfMonths = 12;
            $totalNumberOfExpenses = 0;
            $expensesForCurrentMonth = 0;

            for($i = $currentYear; $i > $earliestYear; $i--){
                echo "<tr>";
                echo "<td>{$i}</td>";

                for($j = 0; $j < $numberOfMonths; $j++){
                    $expensesForCurrentMonth = mt_rand($minimalExpenses, $maxsimalExpenses);
                    $totalNumberOfExpenses += $expensesForCurrentMonth;

                    echo "<td>{$expensesForCurrentMonth}</td>";
                }

                echo "<td>{$totalNumberOfExpenses}</td>";
                echo "</tr>";

                $totalNumberOfExpenses = 0;
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
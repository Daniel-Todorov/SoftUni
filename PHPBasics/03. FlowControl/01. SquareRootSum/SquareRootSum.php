<!--Write a PHP script SquareRootSum.php that displays a table in your browser with 2 columns. -->
<!--The first column should contain a number (even numbers from 0 to 100) -->
<!--and the second column should contain the square root of that number, -->
<!--rounded to the second digit after the decimal point. -->
<!--The last row of the table should contain the sum of all values in the Square column. -->
<!--Styling the page is optional.-->

<!DOCTYPE html>
<html>
<head>
    <title>Square Root sum</title>
</head>
<body>
<section>
    <table border="1">
        <thead>
        <tr>
            <th>Number</th>
            <th>Square</th>
        </tr>
        </thead>
        <tbody>
        <?php
        $initialNumber = 0;
        $maxNumber = 100;
        $totalSumOfSquares = 0;

        for ($currentNumber = $initialNumber; $currentNumber <= $maxNumber; $currentNumber++) {
            if($currentNumber % 2 === 0){
                $squareRootOfCurrentNumber = sqrt($currentNumber);
                $formatedSquareRoot = round($squareRootOfCurrentNumber, 2);
                $totalSumOfSquares += $formatedSquareRoot;
                echo "<tr>";
                echo "<td>{$currentNumber}</td>";
                echo "<td>{$formatedSquareRoot}</td>";
                echo "</tr>";
            }
        }

        $formatedTotalSumOfSquares = round($totalSumOfSquares, 2);
        echo "<tr>";
        echo "<td><strong>Total:</strong></td>";
        echo "<td>{$formatedTotalSumOfSquares}</td>";
        echo "</tr>";
        ?>
        </tbody>
    </table>
</section>
</body>
</html>
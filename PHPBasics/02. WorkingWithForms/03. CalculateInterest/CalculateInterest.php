<!--Write a PHP script CalculateInterest.php which generates an HTML page that contains:-->
<!--•	An input text field to hold the amount of money-->
<!--•	Radio buttons to choose the currency-->
<!--•	An input text field to enter the compound annual interest amount-->
<!--•	A dropdown menu to choose the period of time-->
<!--•	A submit button-->
<!--When the information is submitted, the script should print out the amount of money you will have-->
<!--after the selected period, rounded to 2 decimal places.-->
<!--Semantic HTML is required.-->
<!--Styling is not required.-->

<!DOCTYPE html>
<html>
<head>
    <title>Calculate Interest</title>
</head>
<body>
<section>
    <form method="post">
        <label for="amount">Enter amount: </label>
        <input id="amount" type="number" min="0" value="0" name="amount">
        <br>
        <input id="USD" type="radio" name="currency" value="USD" checked="checked">
        <label for="USD">USD</label>
        <input id="EUR" type="radio" name="currency" value="EUR">
        <label for="EUR">EUR</label>
        <input id="BGN" type="radio" name="currency" value="BGN">
        <label for="BGN">BGN</label>
        <br>
        <label for="interest">Compound Interest Amount: </label>
        <input type="number" name="interest" id="interest" value="0">
        <br>
        <select name="period">
            <option value="6">6 months</option>
            <option value="12">1 year</option>
            <option value="24">2 year</option>
            <option value="60">5 year</option>
        </select>
        <input type="submit" value="Calculate">
        <?php
        if (isset($_POST['amount']) && isset($_POST['currency']) && isset($_POST['interest']) && isset($_POST['period'])) {
            $amountOfMoney = $_POST['amount'];
            $currentAmountOfMoney = $amountOfMoney;
            $currency = $_POST['currency'];
            $interestRatePerYear = $_POST['interest'];
            $interestRatePerMonth = $interestRatePerYear / 12;
            $periodInMonths = $_POST['period'];

            for ($i = 0; $i < $periodInMonths; $i++) {
                $currentAmountOfMoney = $currentAmountOfMoney * ((100 + $interestRatePerMonth) / 100);
            }

            $formatedAmountOfMoney = number_format($currentAmountOfMoney, 2);

            switch($currency){
                case 'USD': $formatedAmountOfMoney = '$ ' . $formatedAmountOfMoney; break;
                case 'EUR': $formatedAmountOfMoney = '&#8364; ' . $formatedAmountOfMoney; break;
                case 'BGN': $formatedAmountOfMoney = 'BGN ' . $formatedAmountOfMoney; break;
            }

            echo $formatedAmountOfMoney;
        }
        ?>
    </form>
</section>
</body>
</html>
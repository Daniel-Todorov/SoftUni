<!DOCTYPE html>
<html>
<head>
    <title>GetFormData</title>
</head>
<body>
<form method="post" action="<?php echo htmlentities($_SERVER['PHP_SELF']); ?>">
    <input type="text" name="name" placeholder="Name">
    <br>
    <input type="number" name="age" placeholder="Age">
    <br>
    <input type="radio" name="gender" value="male" id="male"><label for="male">Male</label>
    <br>
    <input type="radio" name="gender" value="female" id="female"><label for="male">Female</label>
    <br>
    <input type="submit" value="Submit">
</form>
<?php
$hasError = false;
if (!isset($_POST['name']) || empty($_POST['name'])) {
    echo "<p>Please, type a name before submitting the form!</p>";
    $hasError = true;
}
if (!isset($_POST['age']) || empty($_POST['age'])) {
    echo "<p>Please, select an age before submitting the form!</p>";
    $hasError = true;
}
if (!isset($_POST['gender']) || empty($_POST['gender'])) {
    echo "<p>Please, select a gender before submitting the form!</p>";
    $hasError = true;
}
if(!$hasError){
    echo "<p>My name is {$_POST['name']}. I am {$_POST['age']} years old. I am {$_POST['gender']}.";
}
?>
</body>
</html>
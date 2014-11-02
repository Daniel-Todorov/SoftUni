<?php
function isValidNameOrLanguage($input)
{
    $lengthOfInput = mb_strlen($input);

    if ($lengthOfInput > 2 && $lengthOfInput < 21 && ctype_alpha($input)) {
        return true;
    } else {
        return false;
    }
}

function isValidEmail($input)
{
    return filter_var($input, FILTER_VALIDATE_EMAIL);
}

function isValidPhoneNumber($input)
{
    return true;
    //boolval(preg_match('/[0-9\+\-\S]/', $input));
}

function isValidCompanyName($input)
{
    $lengthOfInput = mb_strlen($input);

    if ($lengthOfInput > 2 && $lengthOfInput < 21 && ctype_alpha($input)) { //} && preg_match('/[\W0-9]/', $input)) {
        return true;
    } else {
        return false;
    }
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>CV Generator </title>
    <script src="jquery-2.1.1.min.js"></script>
    <script src="addingAndDeletingFields.js"></script>
</head>
<body>
<section>
    <?php
    if (count($_POST) === 0 || (isset($hasError) && $hasError === true)){
    ?>
    <form method="post">
        <fieldset>
            <legend>Personal Inforamation</legend>
            <input type="text" name="firstName" placeholder="First Name">
            <br>
            <input type="text" name="lastName" placeholder="Last Name">
            <br>
            <input type="email" name="email" placeholder="Email">
            <br>
            <input type="tel" name="phoneNumber" placeholder="Phone Number">
            <br>
            <label for="female">Female</label>
            <input id="female" type="radio" name="gender" value="female">
            <label for="male">Male</label>
            <input id="male" type="radio" name="gender" value="male">
            <br>
            <label for="birthDay">Birthday</label>
            <br>
            <input id="birthDay" type="date" name="birthday">
            <br>
            <label for="nationality">Nationality</label>
            <br>
            <select name="nationality">
                <option value="Bulgarian">Bulgarian</option>
                <option value="American">American</option>
                <option value="Nigerian">Nigerian</option>
                <option value="Indian">Indian</option>
            </select>
        </fieldset>
        <fieldset>
            <legend>Last Work Position</legend>
            <label for="companyName">Company Name</label>
            <input id="companyName" type="text" name="companyName">
            <br>
            <label for="dateFrom">From</label>
            <input id="dateFrom" type="date" name="dateFrom">
            <br>
            <label for="dateTo">To</label>
            <input id="dateTo" type="date" name="dateTo">
        </fieldset>
        <fieldset>
            <legend>Computer Skills</legend>
            <label>Programming Languages</label>
            <br>

            <div class="computerLanguages">
                <input type="text" name="computerLanguages[]">
                <select name="computerLanguageProficiences[]">
                    <option value="Beginner">Beginner</option>
                    <option value="Programmer">Programmer</option>
                    <option value="Ninja">Ninja</option>
                </select>
                <br>
            </div>
            <button id="removeComputerLanguage">Remove Language</button>
            <button id="addComputerLanguage">Add Language</button>
        </fieldset>
        <fieldset>
            <legend>Other Skills</legend>
            <label for="2">Languages</label>
            <br>

            <div class="languages">
                <input type="text" name="languages[]">
                <select name="languageComprehensions[]">
                    <option selected disabled>-Comprehension-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advanced">advanced</option>
                </select>
                <select name="languageReadings[]">
                    <option selected disabled>-Reading-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advanced">advanced</option>
                </select>
                <select name="languageWritings[]">
                    <option selected disabled>-Writing-</option>
                    <option value="beginner">beginner</option>
                    <option value="intermediate">intermediate</option>
                    <option value="advanced">advanced</option>
                </select>
                <br>
            </div>
            <button id="removeLanguage">Remove Language</button>
            <button id="addLanguage">Add Language</button>
            <br>
            <label>Driver's License</label>
            <br>
            <label>B</label>
            <input name="driverLicense[]" type="checkbox" value="B">
            <label>A</label>
            <input name="driverLicense[]" type="checkbox" value="A">
            <label>C</label>
            <input name="driverLicense[]" type="checkbox" value="C">
        </fieldset>
        <input type="submit" value="Generate CV">
    </form>
</section>
<?php
} else {
    if (isset($_POST['firstName']) && isValidNameOrLanguage($_POST['firstName'])) {
        $firstName = $_POST['firstName'];
    } else {
        $hasError = true;
    }

    if (isset($_POST['lastName']) && isValidNameOrLanguage($_POST['lastName'])) {
        $lastName = $_POST['lastName'];
    } else {
        $hasError = true;
    }

    if (isset($_POST['email']) && isValidEmail($_POST['email'])) {
        $email = $_POST['email'];
    } else {
        $hasError = true;
    }

    if (isset($_POST['phoneNumber']) && isValidPhoneNumber($_POST['phoneNumber'])) {
        $phoneNumber = $_POST['phoneNumber'];
    } else {
        $hasError = true;
    }

    $gender = $_POST['gender'];
    $birthday = $_POST['birthday'];
    $nationality = $_POST['nationality'];

    if (isset($_POST['companyName']) && isValidCompanyName($_POST['companyName'])) {
        $companyName = $_POST['companyName'];
    } else {
        $hasError = true;
    }

    $dateFrom = $_POST['dateFrom'];
    $dateTo = $_POST['dateTo'];
    $computerLanguages = $_POST['computerLanguages'];
    $computerLanguageProficiences = $_POST['computerLanguageProficiences'];
    $languages = $_POST['languages'];
    $languageComprehensions = $_POST['languageComprehensions'];
    $languageReadings = $_POST['languageReadings'];
    $languageWritings = $_POST['languageWritings'];
    $driverLicense = $_POST['driverLicense'];
    ?>
    <h1>CV</h1>
    <table border="1">
        <thead>
        <tr>
            <th colspan="2">Personal Information</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td>First Name</td>
            <td><?php echo $firstName; ?></td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td><?php echo $lastName; ?></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><?php echo $email; ?></td>
        </tr>
        <tr>
            <td>Phone Number</td>
            <td><?php echo $phoneNumber; ?></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td><?php echo $gender; ?></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td><?php echo $birthday; ?></td>
        </tr>
        <tr>
            <td>Nationality</td>
            <td><?php echo $nationality; ?></td>
        </tr>
        </tbody>
    </table>
    <table border="1">
        <thead>
        <tr>
            <th colspan="2">Last Work Positon</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td>Company Name</td>
            <td><?php echo $companyName; ?></td>
        </tr>
        <tr>
            <td>From</td>
            <td><?php echo $dateFrom; ?></td>
        </tr>
        <tr>
            <td>To</td>
            <td><?php echo $dateTo; ?></td>
        </tr>
        </tbody>
    </table>
    <table border="1">
        <thead>
        <tr>
            <th colspan="2">Computer Skills</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td rowspan="<?php echo count($computerLanguages); ?>">Programming Languages</td>
            <td>
                <table border="1">
                    <thead>
                    <tr>
                        <th>Language</th>
                        <th>Skill Level</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    $numberOfComputerLanguages = count($computerLanguages);

                    for ($i = 0; $i < $numberOfComputerLanguages; $i++) {
                        ?>
                        <tr>
                            <?php
                            echo "<td>{$computerLanguages[$i]}</td>";
                            echo "<td>{$computerLanguageProficiences[$i]}</td>";
                            ?>
                        </tr>
                    <?php
                    }
                    ?>
                    </tbody>
                </table>
            </td>
        </tr>
        </tbody>
    </table>
    <table border="1">
        <thead>
        <tr>
            <th colspan="2">Other Skills</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td rowspan="<?php echo count($languages); ?>">Languages</td>
            <td>
                <table border="1">
                    <thead>
                    <tr>
                        <th>Language</th>
                        <th>Comprehension</th>
                        <th>Reading</th>
                        <th>Writing</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    $numberOfLanguages = count($languages);

                    for ($i = 0; $i < $numberOfLanguages; $i++) {
                        ?>
                        <tr>
                            <?php
                            echo "<td>{$languages[$i]}</td>";
                            echo "<td>{$languageComprehensions[$i]}</td>";
                            echo "<td>{$languageReadings[$i]}</td>";
                            echo "<td>{$languageWritings[$i]}</td>";
                            ?>
                        </tr>
                    <?php
                    }
                    ?>
                    </tbody>
                </table>
            </td>
        </tr>
        <tr>
            <td>Driver's license</td>
            <td><?php echo implode(', ', $driverLicense); ?></td>
        </tr>
        </tbody>
    </table>
<?php
}
?>
</body>
</html>
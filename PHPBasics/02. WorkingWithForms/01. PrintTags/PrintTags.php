<!--Write a PHP script PrintTags.php which generates an HTML input text field and a submit button. -->
<!--In the text field the user must enter different tags, separated by a comma and a space (", "). -->
<!--When the information is submitted, the script should split the tags, -->
<!--put them in an array and print out the array. -->
<!--Semantic HTML is required. Styling is not required.-->

<!DOCTYPE html>
<html>
<head>
    <title>Print Tags</title>
</head>
<body>
<section>
    <form method="post">
        <label for="tags">Enter tags:</label>
        <input id="tags" type="text" name="tags">
        <input type="submit">
    </form>
</section>
<section>
    <?php
    if (isset($_POST['tags']) && !empty($_POST['tags'])) {
        $tagsAsString = $_POST['tags'];
        $splitedTags = mb_split(', ', $tagsAsString);

        foreach ($splitedTags as $key => $tag) {
            echo "<p>{$key} : {$tag}</p>";
        }
    } else {
        echo 'No string submited yet.';
    }
    ?>
</section>
</body>
</html>
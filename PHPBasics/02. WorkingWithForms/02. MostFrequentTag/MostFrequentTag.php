<!--Write a PHP script MostFrequentTag.php which generates an HTML input text field and a submit button. -->
<!--In the text field the user must enter different tags, separated by a comma and a space (", "). -->
<!--When the information is submitted, the script should generate a list of the tags, sorted by frequency. -->
<!--Then you must print: "Most Frequent Tag is: [most frequent tag]". -->
<!--Semantic HTML is required. -->
<!--Styling is not required.-->

<!DOCTYPE html>
<html>
<head>
    <title>Most Frequent Tag</title>
</head>
<body>
<section>
    <form method="post">
        <label for="tags">Enter tags</label>
        <input id="tags" type="text" name="tags">
        <input type="submit">
    </form>
</section>
<section>
    <?php

    if(isset($_POST['tags']) && !empty($_POST['tags'])){
        $tagsAsString = $_POST['tags'];
        $splittedTags = mb_split(', ', $tagsAsString);

        foreach($splittedTags as $tag){
            if(isset($assocArrayOfTags[$tag])){
                $assocArrayOfTags[$tag]++;
            } else {
                $assocArrayOfTags[$tag] = 1;
            }
        }

        arsort($assocArrayOfTags);
        $keysOfAssocArray = array_keys($assocArrayOfTags);
        $mostOftenUsedKey = $keysOfAssocArray[0];

        foreach($assocArrayOfTags as $tag => $occurance){
            echo "<p>{$tag} : {$occurance} times</p>";
        }

        echo "The most frequent tag is: {$mostOftenUsedKey}";
    }
    ?>
</section>
</body>
</html>
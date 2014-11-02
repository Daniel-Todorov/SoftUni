<!--Write a PHP program SidebarBuilder.php that takes data from several input fields and builds 3 sidebars.-->
<!--The input fields are categories, tags and months. -->
<!--The first sidebar should contain a list of the categories, the second sidebar – -->
<!--a list of the tags and the third should contain the months. -->
<!--The entries in the input strings will be separated by a comma and space ", ". -->
<!--Styling the page is optional. -->
<!--Semantic HTML is required.-->

<!DOCTYPE html>
<html>
<head>
    <title>Sidebar Builder</title>
</head>
<body>
<section>
    <form method="post">
        <label for="categories">Categories:</label>
        <input type="text" name="categories" id="categories">
        <br>
        <label for="tags">Tags:</label>
        <input type="text" name="tags" id="tags">
        <br>
        <label for="months">Months:</label>
        <input type="text" name="months" id="months">
        <br>
        <input type="submit" value="Generate">
    </form>
</section>
<?php
if (isset($_POST['categories']) && isset($_POST['tags']) && isset($_POST['months'])) {
    $categories = mb_split(", ", $_POST['categories']);
    $tags = mb_split(", ", $_POST['tags']);
    $months = mb_split(", ", $_POST['months']);
    $holder = ['Categories' => $categories, 'Tags' => $tags, 'Months' => $months];

    foreach ($holder as $nameOfSidebar => $sidebar) {
        ?>
        <aside>
            <h1><?= $nameOfSidebar ?></h1>
            <ul>
                <?php
                foreach ($sidebar as $record) {
                    echo "<li><a href='#'>{$record}</a></li>";
                }
                ?>
            </ul>
        </aside>

    <?php
    }
}
?>
</body>
</html>
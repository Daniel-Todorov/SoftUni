<!--Write a PHP script HTMLTagsCounter.php which generates an HTML form like in the example below.-->
<!--It should contain a label, an input text field and a submit button.-->
<!--The user enters HTML tag in the input field.-->
<!--If the tag is valid, the script should print “Valid HTML tag!”, and if it is invalid – “Invalid HTML Tag!”.-->
<!--On the second line, there should be a score counter.-->
<!--For every valid tag entered, the score should increase by 1.-->
<!--Hint: You may use sessions.-->
<!--Use an array to store all valid HTML5 tags.-->

<?php
session_start();

$validTags = ['!----',
    '!DOCTYPE',
    'a',
    'abbr',
    'address',
    'area',
    'article',
    'aside',
    'audio',
    'b',
    'base',
    'bdi',
    'bdo',
    'blockquote',
    'body',
    'br',
    'button',
    'canvas',
    'caption',
    'cite',
    'code',
    'col',
    'colgroup',
    'data',
    'datalist',
    'dd',
    'del',
    'details',
    'dfn',
    'dialog',
    'div',
    'dl',
    'dt',
    'em',
    'embed',
    'fieldset',
    'figcaption',
    'figure',
    'footer',
    'form',
    'h1',
    'h2',
    'h3',
    'h4',
    'h5',
    'h6',
    'head',
    'header',
    'hgroup',
    'hr',
    'html',
    'i',
    'iframe',
    'img',
    'input',
    'ins',
    'kbd',
    'keygen',
    'label',
    'legend',
    'li',
    'link',
    'main',
    'map',
    'mark',
    'menu',
    'menuitem',
    'meta',
    'meter',
    'nav',
    'noscript',
    'object',
    'ol',
    'optgroup',
    'option',
    'output',
    'p',
    'param',
    'pre',
    'progress',
    'q',
    'rb',
    'rp',
    'rt',
    'rtc',
    'ruby',
    's',
    'samp',
    'script',
    'section',
    'select',
    'small',
    'source',
    'span',
    'strong',
    'style',
    'sub',
    'summary',
    'sup',
    'table',
    'tbody',
    'td',
    'template',
    'textarea',
    'tfoot',
    'th',
    'thead',
    'time',
    'title',
    'tr',
    'track',
    'u',
    'ul',
    'var',
    'video',
    'wbr'];
?>


<!DOCTYPE html>
<html>
<head>
    <title>HTML Tags Counter</title>
</head>
<body>
<section>
    <form method="post">
        <label for="input">Enter HTML tag: </label>
        <br>
        <input type="text" id="input" name="input">
        <input type="submit">
    </form>
</section>
<section>
    <?php
    if(!isset($_SESSION['scoreCount'])){
        $_SESSION['scoreCount'] = 0;
    }

    if(isset($_POST['input'])){
        if(in_array($_POST['input'], $validTags)){
            $_SESSION['scoreCount']++;
            echo '<p>Valid HTML tag!</p>';
        } else {
            echo '<p>Invalid HTML tag!</p>';
        }
    }

    echo "Score: {$_SESSION['scoreCount']}";
    ?>
</section>
</body>
</html>
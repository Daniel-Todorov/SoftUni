<?php
/**
 * Created by PhpStorm.
 * User: Daniel Todorov
 * Date: 14-8-31
 * Time: 11:07
 */

$allowedTags = ['main', 'header', 'section', 'nav', 'article', 'aside', 'footer'];

$html = $_GET['html'];

$linesOfHtml = explode(PHP_EOL, $html);

$result = [];

foreach ($linesOfHtml as $line) {
    if (preg_match("/<div\s+/", $line)) {

        foreach ($allowedTags as $tag) {
            if (preg_match("/.*\s+id\s*=\s*\"\s*" . $tag . "\s*\"\s*.*/", $line) || preg_match("/.*\s+class\s*=\s*\"\s*" . $tag . "\s*\"\s*.*/", $line)) {
                $modifiedLine = preg_replace("/<div/", "<" . $tag, $line);
                $modifiedLine = preg_replace("/\s*id\s*=\s*\"\s*" . $tag . "\s*\"\s*/", " ", $modifiedLine);
                $modifiedLine = preg_replace("/\s*class\s*=\s*\"\s*" . $tag . "\s*\"\s*/", " ", $modifiedLine);

                $modifiedLine = preg_replace("/\s*>/", ">", $modifiedLine);

                array_push($result, $modifiedLine);
            }
        }
    } elseif (preg_match("/<\/div>/", $line)) {

        foreach ($allowedTags as $tag) {
            if (preg_match("/.*<!--\s*" . $tag . "\s*-->.*/", $line)) {
                $modifiedLine = preg_replace("/<\/div/", "</" . $tag, $line);
                $modifiedLine = preg_replace("/\s*<!--\s*" . $tag . "\s*-->\s*/", "", $modifiedLine);

                //$modifiedLine = preg_replace("/\s+/", " ", $modifiedLine);

                array_push($result, $modifiedLine);
            }
        }

    } else {
        array_push($result, $line);
    }
}

$result = implode(PHP_EOL, $result);

echo htmlspecialchars($result);
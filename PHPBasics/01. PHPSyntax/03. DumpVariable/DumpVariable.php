<?php
/**
 * Write a PHP script DumpVariable.php that declares a variable.
 * If the variable is numeric, print it by the built-in function var_dump().
 * If the variable is not numeric, print its type at the input.
 */

function dumpVariable($variable)
{
    if (is_numeric($variable)) {
        var_dump($variable);
    } else {
        echo gettype($variable);
    }
}

dumpVariable("hello");
echo "<br>";
dumpVariable(15);
echo "<br>";
dumpVariable(1.234);
echo "<br>";
dumpVariable(array(1,2,3));
echo "<br>";
dumpVariable((object)[2,34]);
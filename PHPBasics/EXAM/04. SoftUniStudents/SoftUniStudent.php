<?php
/**
 * Created by PhpStorm.
 * User: Daniel Todorov
 * Date: 14-8-31
 * Time: 14:04
 */

$students = $_GET['students'];
$column = $_GET['column'];
$order = $_GET['order'];

$separatdStudents = explode(PHP_EOL, $students);

var_dump($separatdStudents);
<?php
/**
 * Created by PhpStorm.
 * User: Daniel Todorov
 * Date: 14-8-31
 * Time: 14:04
 */

function sortByResult($a, $b)
{
    if ($a['result'] === $b['result']) {
        return ($a['id'] < $b['id']) ? -1 : 1;
    }

    return (intval($a['result']) < $b['result']) ? -1 : 1;
}

function sortById($a, $b)
{
    return ($a['id'] < $b['id']) ? -1 : 1;
}

function sortByUsername($a, $b)
{
    if ($a['name'] === $b['name']) {
        return ($a['id'] < $b['id']) ? -1 : 1;
    }

    return ($a['name'] < $b['name']) ? -1 : 1;
}

function sortStudents($arrayOfStudents, $orderColumn, $orderType)
{
    switch ($orderColumn) {
        case "id":
            usort($arrayOfStudents, "sortById");
            break;
        case "username":
            usort($arrayOfStudents, "sortByUsername");
            break;
        case "result":
            usort($arrayOfStudents, "sortByResult");
            break;
        default:
            break;
    }

    if ($orderType === "descending") {
        $arrayOfStudents = array_reverse($arrayOfStudents);
    }

    return $arrayOfStudents;
}

$students = $_GET['students'];
$column = $_GET['column'];
$order = $_GET['order'];

$separatedStudents = explode(PHP_EOL, $students);

$arrayOfStudents = [];

$idCounter = 1;

foreach ($separatedStudents as $studentRecords) {
    $splittedRecords = explode(", ", $studentRecords);
    $student = ['id' => $idCounter, 'name' => $splittedRecords[0], 'mail' => $splittedRecords[1], 'type' => $splittedRecords[2], 'result' => $splittedRecords[3]];
    $idCounter++;

    array_push($arrayOfStudents, $student);
}

$arrayOfStudents = sortStudents($arrayOfStudents, $column, $order);

$numberOfStudents = count($arrayOfStudents);

$result = "";

$result .= "<table>";
$result .= "<thead>";
$result .= "<tr>";
$result .= "<th>Id</th>";
$result .= "<th>Username</th>";
$result .= "<th>Email</th>";
$result .= "<th>Type</th>";
$result .= "<th>Result</th>";
$result .= "</tr>";
$result .= "</thead>";

for ($i = 0; $i < $numberOfStudents; $i++) {
    $result .= "<tr>";
    $result .= "<td>" . htmlspecialchars($arrayOfStudents[$i]['id']) . "</td>";
    $result .= "<td>" . htmlspecialchars($arrayOfStudents[$i]['name']) . "</td>";
    $result .= "<td>" . htmlspecialchars($arrayOfStudents[$i]['mail']) . "</td>";
    $result .= "<td>" . htmlspecialchars($arrayOfStudents[$i]['type']) . "</td>";
    $result .= "<td>" . htmlspecialchars($arrayOfStudents[$i]['result']) . "</td>";
    $result .= "</tr>";
}

$result .= "</table>";

echo $result;
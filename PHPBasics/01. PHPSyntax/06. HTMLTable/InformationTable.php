<?php
/**
 * Write a PHP script InformationTable.php which generates an HTML table
 * by given information about a person (name, phone number, age, address).
 * Styling the table is optional.
 * Semantic HTML is required.
 */

function generateTable($name, $phoneNumber, $age, $address){
    $htmlTable = "<table border='1'><thead><tr><th>Name</th><th>Phone number</th><th>Age</th><th>Address</th></tr></thead>"
        ."<tbody><tr><td>{$name}</td><td>{$phoneNumber}</td><td>{$age}</td><td>{$address}</td></tr></tbody></table>";

    echo $htmlTable;
}

generateTable("Gosho", "0882-321-423", 24, "Hadji Dimitar");
generateTable("Pesho", "0884-888-888", 67, "Suhata Reka");
<?php

function __autoload($classname)
{
    include_once("./" . $classname . ".class.php");
}

$room = new SingleRoom(1408, 99);
$guest = new Guest("Svetlin", "Nakov", 8003224277);
$startDate = strtotime("24.10.2014");
$endDate = strtotime("26.10.2014");
$reservation = new Reservation($startDate, $endDate, $guest);

BookingManager::bookRoom($room, $reservation);
BookingManager::bookRoom($room, $reservation);

$bedroom = new Bedroom(1209, 199);
$apartment = new Apartment(1001, 299);

$rooms = [$room, $bedroom, $apartment];

$cheapBedroomsAndApartments = array_filter($rooms, function ($r) {
    if (($r instanceof Bedroom || $r instanceof Apartment) && $r->getRoomInformation()->getPrice() <= 250) {
        return true;
    }

    return false;
});

var_dump($cheapBedroomsAndApartments);

$roomsWithBalcony = array_filter($rooms, function ($r) {
    return $r->getRoomInformation()->getHasBalcony();
});

var_dump($roomsWithBalcony);

$roomsWithBathtub = array_filter($rooms, function ($r) {
    return in_array("bathtub", $r->getRoomInformation()->getExtras());
});

var_dump($roomsWithBathtub);
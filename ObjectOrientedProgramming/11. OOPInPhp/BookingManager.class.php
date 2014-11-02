<?php

class BookingManager
{
    /**
     * @param Room $room
     * @param Reservation $reservation
     */
    static function bookRoom($room, $reservation)
    {
        try {
            $room->addReservation($reservation);

            echo "<p>Room <strong>" . $room->getRoomInformation()->getRoomNumber() . "</strong> "
                . "successfully booked for <strong>" . $reservation->getGuest()->getFirstName() . " "
                . $reservation->getGuest()->getLastName() . "</strong> "
                . "from <time>" . date('d.m.Y', $reservation->getStartDate()) . "</time> to "
                . "<time>" . date('d.m.Y', $reservation->getEndDate()) . "</time>!</p>";
        } catch (EReservationException $ex) {
            echo "<p>" . $ex->getMessage() . "</p>";
        }
    }
} 
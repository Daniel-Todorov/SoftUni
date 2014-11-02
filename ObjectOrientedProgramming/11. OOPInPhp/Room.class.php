<?php

abstract class Room implements iReservable
{
    private $roomInformation;
    private $reservations;

    function __construct(RoomInformation $roomInformation, Array $reservations)
    {
        $this->setReservations($reservations);
        $this->setRoomInformation($roomInformation);
    }

    public function addReservation(Reservation $reservation)
    {
        foreach ($this->getReservations() as $existingReservation) {



            if (($existingReservation->getStartDate() <= $reservation->getStartDate() && $reservation->getStartDate() <= $existingReservation->getEndDate())
                || ($existingReservation->getStartDate() <= $reservation->getEndDate() && $reservation->getEndDate() <= $existingReservation->getEndDate())
            ) {
                throw new EReservationException();
            }
        }

        array_push($this->reservations, $reservation);
    }

    public function removeReservation(Reservation $reservation)
    {
        $this->setReservations(array_filter($this->reservations, function ($key, $value) use ($reservation) {
            if ($reservation->getGuest()->getId() === $value->getGuest()->getId()
                && $reservation->getStartDate() === $value->getStartDate()
                && $reservation->getEndDate() === $value->getEndDate()
            ) {
                return false;
            }

            return true;
        }, ARRAY_FILTER_USE_BOTH));
    }

    /**
     * @param array $reservations
     */
    public function setReservations($reservations)
    {
        $this->reservations = $reservations;
    }

    /**
     * @return array
     */
    public function getReservations()
    {
        return $this->reservations;
    }

    /**
     * @param RoomInformation $roomInformation
     */
    public function setRoomInformation($roomInformation)
    {
        $this->roomInformation = $roomInformation;
    }

    /**
     * @return RoomInformation
     */
    public function getRoomInformation()
    {
        return $this->roomInformation;
    }
} 
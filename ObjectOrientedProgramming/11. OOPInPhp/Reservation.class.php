<?php

class Reservation
{
    const FORMAT = 'd#m#Y';
    private $startDate;
    private $endDate;
    private $guest;

    /**
     * @param timestamp $endDate
     * @param Guest $guest
     * @param timestamp $startDate
     */
    function __construct($startDate, $endDate, $guest)
    {
        $this->setEndDate($endDate);
        $this->setGuest($guest);
        $this->setStartDate($startDate);
    }

    /**
     * @param timestamp $endDate
     */
    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    /**
     * @return timestamp
     */
    public function getEndDate()
    {
        return $this->endDate;
    }

    /**
     * @param Guest $guest
     */
    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    /**
     * @return Guest
     */
    public function getGuest()
    {
        return $this->guest;
    }

    /**
     * @param timestamp $startDate
     */
    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    /**
     * @return timestamp
     */
    public function getStartDate()
    {
        return $this->startDate;
    }
} 
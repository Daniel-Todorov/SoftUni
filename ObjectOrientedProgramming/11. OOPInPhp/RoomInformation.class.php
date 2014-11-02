<?php

class RoomInformation
{
    private $roomType;
    private $hasRestRoom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $extras;
    private $price;

    /**
     * @param int $bedCount
     * @param string[] $extras
     * @param bool $hasBalcony
     * @param bool $hasRestRoom
     * @param num $price
     * @param int $roomNumber
     * @param RoomType $roomType
     */
    function __construct($bedCount, $extras, $hasBalcony, $hasRestRoom, $price, $roomNumber, $roomType)
    {
        $this->bedCount = $bedCount;
        $this->extras = $extras;
        $this->hasBalcony = $hasBalcony;
        $this->hasRestRoom = $hasRestRoom;
        $this->price = $price;
        $this->roomNumber = $roomNumber;
        $this->roomType = $roomType;
    }

    /**
     * @param mixed $bedCount
     */
    public function setBedCount($bedCount)
    {
        $this->bedCount = $bedCount;
    }

    /**
     * @return mixed
     */
    public function getBedCount()
    {
        return $this->bedCount;
    }

    /**
     * @param mixed $extras
     */
    public function setExtras($extras)
    {
        $this->extras = $extras;
    }

    /**
     * @return mixed
     */
    public function getExtras()
    {
        return $this->extras;
    }

    /**
     * @param mixed $hasBalcony
     */
    public function setHasBalcony($hasBalcony)
    {
        $this->hasBalcony = $hasBalcony;
    }

    /**
     * @return mixed
     */
    public function getHasBalcony()
    {
        return $this->hasBalcony;
    }

    /**
     * @param mixed $hasRestRoom
     */
    public function setHasRestRoom($hasRestRoom)
    {
        $this->hasRestRoom = $hasRestRoom;
    }

    /**
     * @return mixed
     */
    public function getHasRestRoom()
    {
        return $this->hasRestRoom;
    }

    /**
     * @param mixed $price
     */
    public function setPrice($price)
    {
        $this->price = $price;
    }

    /**
     * @return mixed
     */
    public function getPrice()
    {
        return $this->price;
    }

    /**
     * @param mixed $roomNumber
     */
    public function setRoomNumber($roomNumber)
    {
        $this->roomNumber = $roomNumber;
    }

    /**
     * @return mixed
     */
    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    /**
     * @param mixed $roomType
     */
    public function setRoomType($roomType)
    {
        $this->roomType = $roomType;
    }

    /**
     * @return mixed
     */
    public function getRoomType()
    {
        return $this->roomType;
    }


}
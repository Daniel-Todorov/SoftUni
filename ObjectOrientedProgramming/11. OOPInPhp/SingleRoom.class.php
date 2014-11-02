<?php

class SingleRoom extends Room
{

    /**
     * @param int $roomNumber
     * @param float $price
     */
    function __construct($roomNumber, $price)
    {
        $roomInformation = new RoomInformation(1, ['TV', 'air-conditioner'],
            false, true, $price, $roomNumber, RoomType::Standard);
        parent::__construct($roomInformation, Array());
    }
}
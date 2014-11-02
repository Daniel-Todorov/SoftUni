<?php

class Bedroom extends Room
{

    /**
     * @param int $roomNumber
     * @param float $price
     */
    function __construct($roomNumber, $price)
    {
        $roomInformation = new RoomInformation(2, ['TV', 'air-conditioner', 'refrigerator', 'mini-bar', 'bathtub'],
            true, true, $price, $roomNumber, RoomType::Gold);
        parent::__construct($roomInformation, Array());
    }
} 
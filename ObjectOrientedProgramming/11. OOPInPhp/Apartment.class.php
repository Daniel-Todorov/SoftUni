<?php

class Apartment extends Room
{

    /**
     * @param int $roomNumber
     * @param float $price
     */
    function __construct($roomNumber, $price)
    {
        $roomInformation = new RoomInformation(4, ['TV', 'air-conditioner', 'refrigerator', 'kitchen box', 'mini-bar', 'bathtub', 'free Wi-fi'],
            false, true, $price, $roomNumber, RoomType::Diamond);
        parent::__construct($roomInformation, Array());
    }
} 
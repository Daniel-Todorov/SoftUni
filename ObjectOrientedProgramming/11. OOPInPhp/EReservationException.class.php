<?php

class EReservationException extends Exception {
    public function __construct(){
        parent::__construct("Reservation for this period already exists.", 909);
    }
} 
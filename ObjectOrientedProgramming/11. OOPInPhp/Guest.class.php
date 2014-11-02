<?php

class Guest
{
    private $firstName;
    private $lastName;
    private $id;

    /**
     * @param string $firstName
     * @param string $id
     * @param string $lastName
     */
    function __construct($firstName, $lastName, $id)
    {
        $this->setFirstName($firstName);
        $this->setId($id);
        $this->setLastName($lastName);
    }

    /**
     * @param string $firstName
     */
    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }

    /**
     * @return string
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param string $id
     */
    public function setId($id)
    {
        $this->id = $id;
    }

    /**
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * @param string $lastName
     */
    public function setLastName($lastName)
    {
        $this->lastName = $lastName;
    }

    /**
     * @return string
     */
    public function getLastName()
    {
        return $this->lastName;
    }
} 
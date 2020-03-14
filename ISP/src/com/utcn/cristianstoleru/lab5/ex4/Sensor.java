package com.utcn.cristianstoleru.lab5.ex4;

abstract class Sensor {
    private String location;

    abstract int readValue();

    public String getLocation() {
        return location;
    }
}

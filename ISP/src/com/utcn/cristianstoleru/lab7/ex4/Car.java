package com.utcn.cristianstoleru.lab7.ex4;

import java.io.Serializable;
import java.util.Objects;

public class Car implements Serializable {
    private String brandName;
    private String numberID;
    private int horsePower;
    private transient static int number=0;

    public Car(String brandName, String numberID, int horsePower) {
        this.brandName = brandName;
        this.numberID = numberID;
        this.horsePower = horsePower;
        this.number++;
    }

    public static int getNumber() {
        return number;
    }

    public String getBrandName() {
        return brandName;
    }

    public void setBrandName(String brandName) {
        this.brandName = brandName;
    }

    public String getNumberID() {
        return numberID;
    }

    public void setNumberID(String numberID) {
        this.numberID = numberID;
    }

    public int getHorsePower() {
        return horsePower;
    }

    public void setHorsePower(int horsePower) {
        this.horsePower = horsePower;
    }

    @Override
    public String toString() {
        return "Car{" +
                "Brand Name='" + brandName + '\'' +
                ", Number ID='" + numberID + '\'' +
                ", Horse Power=" + horsePower +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car car = (Car) o;
        return numberID.equals(car.numberID);
    }

    @Override
    public int hashCode() {
        return Objects.hash(numberID);
    }
}

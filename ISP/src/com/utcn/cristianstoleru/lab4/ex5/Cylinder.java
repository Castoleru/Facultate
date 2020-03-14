package com.utcn.cristianstoleru.lab4.ex5;

import com.utcn.cristianstoleru.lab4.ex1.Circle;

public class Cylinder extends Circle {
    private double height;

    public Cylinder() {
        super();
        this.height = 1.0;
    }

    public Cylinder(double radius) {
        super(radius);
        this.height = 1.0;
    }

    public Cylinder(double radius, double height) {
        super(radius);
        this.height = height;
    }

    public double getHeight() {
        return this.height;
    }

    @Override
    public double getArea() {
        return 2*super.getArea()+2*3.14*this.getRadius();
    }

    public double getVolume() {
        return this.height * this.getArea();
    }
}

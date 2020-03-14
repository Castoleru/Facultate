package com.utcn.cristianstoleru.lab4.ex6;

public class Rectangle extends Shape {
    private double width;
    private double lenght;

    public Rectangle() {
        this.width = 1.0;
        this.lenght = 1.0;
    }

    public Rectangle(double width, double lenght) {
        this.width = width;
        this.lenght = lenght;
    }

    public Rectangle(String color, boolean filled, double width, double lenght) {
        super(color, filled);
        this.width = width;
        this.lenght = lenght;
    }

    public double getLenght() {
        return lenght;
    }

    public void setLenght(double lenght) {
        this.lenght = lenght;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getArea() {
        return this.lenght * this.width;
    }

    public double getPerimeter() {
        return 2 * this.width + 2 * this.lenght;
    }

    @Override
    public String toString() {
        return "Rectangle{" +
                "width=" + width +
                ", lenght=" + lenght +
                '}'+"which is a subclass of"+super.toString();
    }
}

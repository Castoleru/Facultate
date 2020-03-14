package com.utcn.cristianstoleru.lab5.ex1;

public class Square extends Rectangle {
    public Square() {
        super();
    }

    public Square(double side) {
        super(side, side);
    }

    public Square(String color, boolean filled, double side) {
        super(color, filled, side, side);
    }

    public double getSide() {
        return super.getWidth();
    }

    public void setSide(double side) {
        super.setWidth(side);
        super.setLenght(side);
    }

    @Override
    public void setWidth(double side) {
        super.setWidth(side);
        super.setLenght(side);
    }

    @Override
    public void setLenght(double side) {
        super.setWidth(side);
        super.setLenght(side);
    }

    @Override
    public String toString() {
        return "A Square with side" + this.getSide() + "which is a subclass of " + super.toString();
    }
}

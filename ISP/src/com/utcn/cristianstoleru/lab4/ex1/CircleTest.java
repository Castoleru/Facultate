package com.utcn.cristianstoleru.lab4.ex1;

public class CircleTest {
    public static void main(String[] args) {
        Circle c1 = new Circle();
        Circle c2 = new Circle(3.2);
        System.out.println(c1.getRadius() + " " + c1.getArea());
        System.out.println(c2.getRadius() + " " + c2.getArea());

    }
}

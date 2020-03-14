package com.utcn.cristianstoleru.lab3.ex4;

public class TestMyPoint {
    public static void main(String[] args) {
        MyPoint m1 = new MyPoint();
        MyPoint m2 = new MyPoint(11, 11);
        m1.setXY(5, 4);
        System.out.println(m1.distance(5, 7));
        System.out.println(m1.distance(m2));
    }
}

package com.utcn.cristianstoleru.lab5.ex1;

public class Ex6Test {
    public static void main(String[] args) {


        Circle c = new Circle(12, "green", true);
        c.setRadius(3);
        System.out.println(c.getArea() + " " + c.getPerimeter() + " " + c.getRadius() + " " + c.toString());

        Rectangle r = new Rectangle("red", true, 2, 3);
        r.setLenght(3);
        r.setWidth(2);
        System.out.println(r.getWidth() + " " + r.getLenght() + " " + r.getArea() + " " + r.getPerimeter() + " " + r.getArea() + " " + r.toString());

        Square p = new Square("black", true, 4);
        p.setLenght(1);
        System.out.println(p.getSide());
        p.setWidth(2);
        System.out.println(p.getSide());
        p.setSide(3);
        System.out.println(p.getSide());
        System.out.println(p.toString());
    }
}

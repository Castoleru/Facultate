package com.utcn.cristianstoleru.lab3.ex2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class TestCircle {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Circle c1 = new Circle();
        System.out.println("Insert a radius");
        double radius = Double.parseDouble(br.readLine());
        Circle c2 = new Circle(radius);
        Circle c3 = new Circle(23.0, "Green");
        System.out.println(c1.getColor() + c1.getRadius());
        System.out.println(c2.getColor() + c2.getRadius());
        System.out.println(c3.getColor() + c3.getRadius());
    }
}

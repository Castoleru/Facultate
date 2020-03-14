package com.utcn.cristianstoleru.lab3.ex2;

import javax.script.ScriptContext;

public class Circle {
    double radius;

    String color;

    Circle() {
        radius = 1.0;
        color = "red";
    }

    Circle(double r) {
        this();
        radius = r;
    }

    Circle(double r, String s) {
        radius = r;
        color = s;
    }

    public String getColor() {
        return color;
    }

    public double getRadius() {
        return radius;
    }
}

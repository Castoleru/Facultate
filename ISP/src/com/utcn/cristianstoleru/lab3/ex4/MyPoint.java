package com.utcn.cristianstoleru.lab3.ex4;

public class MyPoint {
    int x;
    int y;

    public MyPoint() {
        x = 0;
        y = 0;
    }

    MyPoint(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public void setX(int x) {
        this.x = x;
    }

    public void setY(int y) {
        this.y = y;
    }

    public void setXY(int x, int y) {
        this.setX(x);
        this.setY(y);
    }

    public String toSting() {
        return "(" + this.x + "," + this.y + ")";
    }

    public double distance(int x, int y) {
        return Math.sqrt((this.x - x)*(this.x - x)+ (this.y - y)*(this.y - y));
    }

    public double distance(MyPoint mp) {
        return Math.sqrt((this.x - mp.x)*(this.x - mp.x) + (this.y - mp.y)*(this.y - mp.y));
    }
}

package com.utcn.cristianstoleru.lab10.ex4;

public class Robot  {
    private Point poz;
    private String name;

    public Robot(String name, Point poz) {
        this.name=name;
        this.poz = poz;
    }

    public String getName() {
        return name;
    }

    public void setPoz(Point poz) {
        this.poz = poz;
    }

    private void distroy(Robot robot) {
        if (this.poz == robot.poz && (this.poz.getX() > 0 || this.poz.getY() > 0)) {
            this.setPoz((new Point(-1, -1)));
            robot.setPoz(new Point(-1, -1));
            System.out.println("Robotul " + this.getName() + " and " + robot.getName() + " have been destroyed");
        }
    }

    public void move() {
        this.setPoz(new Point((int)(Math.random()*100),(int)(Math.random()*100)));
    }



}

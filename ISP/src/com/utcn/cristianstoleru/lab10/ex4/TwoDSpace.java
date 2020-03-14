package com.utcn.cristianstoleru.lab10.ex4;

import java.util.ArrayList;

public class TwoDSpace extends Thread{
    private ArrayList<Robot> robots=new ArrayList<>();

    public TwoDSpace() {
        robots.add(0,new Robot("Robot 1",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(1,new Robot("Robot 2",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(2,new Robot("Robot 3",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(3,new Robot("Robot 4",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(4,new Robot("Robot 5",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(5,new Robot("Robot 6",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(6,new Robot("Robot 7",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(7,new Robot("Robot 8",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(8,new Robot("Robot 9",new Point((int)(Math.random()*100),(int)(Math.random()*100))));
        robots.add(9,new Robot("Robot 10",new Point((int)(Math.random()*100),(int)(Math.random()*100))));

    }




}

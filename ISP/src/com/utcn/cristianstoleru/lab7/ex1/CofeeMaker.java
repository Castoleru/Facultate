package com.utcn.cristianstoleru.lab7.ex1;

class CofeeMaker {
    Cofee makeCofee(){
        System.out.println("Make a coffe");
        int t = (int)(Math.random()*100);
        int c = (int)(Math.random()*100);
        Cofee cofee = new Cofee(t,c);
        return cofee;
    }

}
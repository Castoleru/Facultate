package com.utcn.cristianstoleru.lab3.ex5;

public class Flower {
    int petal;
    static int countFlower = 0;

    Flower() {
        System.out.println("Flower has been created!");
        countFlower++;
    }

    public static int getCountFlower() {
        return countFlower;
    }

    public static void main(String[] args) {
        Flower[] garden = new Flower[5];
        for (int i = 0; i < 5; i++) {
            Flower flow = new Flower();
        }
        System.out.println(+garden[0].getCountFlower());
    }
}
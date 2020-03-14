package com.utcn.cristianstoleru.lab2.ex7;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Math.random;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int life = 3, rand, number;
        rand = (int) (random() * 10);
        while (life!=0) {
            System.out.println("Insert a number(0-9): ");
            number = Integer.parseInt(br.readLine());
            if (rand > number) {
                System.out.println("Wrong answer, your number is too low");
                life--;
            } else if (rand < number) {
                System.out.println("Wrong answer, your number it too high");
                life--;
            } else if (rand == number) {
                System.out.println("Correct answer");
                System.out.println("Press Any Key To Continue...");
                new java.util.Scanner(System.in).nextLine();
                return;
            }
        }
    }
}

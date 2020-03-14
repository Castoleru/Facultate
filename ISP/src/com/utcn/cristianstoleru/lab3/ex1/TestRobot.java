package com.utcn.cristianstoleru.lab3.ex1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class TestRobot {
    public static void main(String[] args) throws IOException {
        Robot r1 = new Robot();
        System.out.println("Inset the value for movement: ");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int k = Integer.parseInt(br.readLine());
        r1.change(k);
        r1.printPozition();

    }
}

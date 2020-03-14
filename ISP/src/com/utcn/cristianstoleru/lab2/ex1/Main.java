package com.utcn.cristianstoleru.lab2.ex1;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Insert a number:");
        int a=Integer.parseInt(br.readLine());
        System.out.println("Insert a number:");
        int b=Integer.parseInt(br.readLine());
        if(a>b) System.out.println("max="+a);
        else System.out.println("max="+b);

    }
}

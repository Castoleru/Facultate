package com.utcn.cristianstoleru.lab2.ex6;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static int factorial(int a)
    {
        int i,fac=1;
        if(a==0 || a==1) return 1;
        for(i=2;i<=a;i++)
            fac*=i;
        return fac;
    }
    public static int factorialRec(int a)
    {
        if(a==0)return 1;
        else return a*factorialRec(a-1);
    }

    public static void main(String[] args) throws IOException {
        BufferedReader br= new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Insert a number");
        int a=Integer.parseInt(br.readLine());
        System.out.println("Non recursive method:"+factorial(a)+"\n Recursive method:"+factorialRec(a));
    }
}

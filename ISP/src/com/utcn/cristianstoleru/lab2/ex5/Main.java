package com.utcn.cristianstoleru.lab2.ex5;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int[] v = new int[10];
        int i, j,aux;
        for (i = 0; i < 10; i++) {
            System.out.println("Index: " + i + " Number : ");
            v[i] = Integer.parseInt(br.readLine());
        }
        for (i = 0; i < 9; i++)
            for (j = i + 1; j < 10; j++)
                if(v[i]>v[j])
                {
                    aux=v[i];
                    v[i]=v[j];
                    v[j]=aux;
                }
        for(i=0;i<10;i++) System.out.println(v[i]);
    }
}

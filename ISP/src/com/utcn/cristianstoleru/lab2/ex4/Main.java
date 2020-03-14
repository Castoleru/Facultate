package com.utcn.cristianstoleru.lab2.ex4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.Buffer;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br= new BufferedReader(new InputStreamReader(System.in));
        int n=Integer.parseInt(br.readLine());
        float[] v=new float[n];
        int i;
        float maximus=0;
        for(i=0;i<n;i++)
        {
            v[i]=Float.parseFloat(br.readLine());
            if(v[i]>maximus)
                maximus=v[i];
        }
        System.out.println("The Maximum element is "+maximus);

    }
}

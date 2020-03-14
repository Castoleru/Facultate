package com.utcn.cristianstoleru.lab2.ex3;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Math.sqrt;

public class Main {
    public static boolean prim(int a) {
        int i;
        if (a <= 2) return true;
        else if (a % 2 == 0)
            return false;
        else {
            for (i = 3; i <= sqrt(a); i++) {
                if (a % i == 0)
                    return false;
            }
            return true;

        }

    }

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("A=");
        int a = Integer.parseInt(br.readLine());
        System.out.println("B=");
        int b = Integer.parseInt(br.readLine());
        int count = 0;
        for (++a; a < b; ++a)
            if (prim(a)) {
                count++;
                System.out.println(+count + ":" + a);
            }

    }
}


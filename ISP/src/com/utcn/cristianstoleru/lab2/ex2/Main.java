package com.utcn.cristianstoleru.lab2.ex2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Introdu un numar");
        int n=Integer.parseInt(br.readLine());
        switch (n) {
            case 1:
                System.out.println("UNU");
                break;
            case 2:
                System.out.println("DOI");
                break;
            case 3:
                System.out.println("Trei");
                break;
            case 4:
                System.out.println("Patru");
                break;
            case 5:
                System.out.println("Cinci");
                break;
            case 6:
                System.out.println("Sase");
                break;
            case 7:
                System.out.println("Sapte");
                break;
            case 8:
                System.out.println("Opt");
                break;
            case 9:
                System.out.println("noua");
                break;
            case 0:
                System.out.println("Zero");
                break;
            default:
                System.out.println("Cifra necunoscuta");
        }
        if(n==1)
            System.out.println("Unu");
        else if(n==2) System.out.println("doi");
                else if(n==3) System.out.println("trei");
                    else if(n==4) System.out.println("patru");
                        else System.out.println("alta cifra");
    }
}

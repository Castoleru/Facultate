package com.utcn.cristianstoleru.lab7.ex1;

class Cofee {
    private int temp;
    private int conc;
    static int numberCofee = 0;

    Cofee(int t, int c) {
        temp = t;
        conc = c;
        numberCofee++;
    }

    int getTemp() {
        return temp;
    }

    static int getNumberCofee() {
        return numberCofee;
    }

    int getConc() {
        return conc;
    }

    public String toString() {
        return "[cofee temperature=" + temp + ":concentration=" + conc + "]";
    }
}
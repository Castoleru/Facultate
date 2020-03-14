package com.utcn.cristianstoleru.lab10.ex3;

public class Main {
    public static void main(String[] args) {
        Counter c1 = new Counter("counter1");
        Counter c2 = new Counter("counter2");
        c1.setStartUltim(0, 100);
        c2.setStartUltim(100, 200);
        c1.run();
        c2.run();
    }
}

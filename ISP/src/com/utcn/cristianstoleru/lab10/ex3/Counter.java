package com.utcn.cristianstoleru.lab10.ex3;

public class Counter extends Thread {
    private int start;
    private int ultim;

    Counter(String name) {
        super(name);
    }


    public void setStart(int start) {
        this.start = start;
    }

    public void setUltim(int ultim) {
        this.ultim = ultim;
    }

    public void setStartUltim(int start, int ultim) {
        this.setStart(start);
        this.setUltim(ultim);
    }

    public void run() {
        for (int i = this.start; i < this.ultim; i++) {
            System.out.println(getName() + " i = " + i);
            try {
                Thread.sleep(50);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        System.out.println(getName() + " job finalised.");
    }
}

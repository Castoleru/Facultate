package com.utcn.cristianstoleru.lab7.ex1;

public class OutOfNumberException extends Exception {
    int number;
    public OutOfNumberException(int number,String msg) {
        super(msg);
        this.number = number;
    }

    int getNumber(){
        return number;
    }
}

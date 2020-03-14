package com.utcn.cristianstoleru.lab6.ex1;

public class TestMain {
    public static void main(String[] args) {
        BankAccount cas=new BankAccount("Cristian",90);
        BankAccount bgd=new BankAccount("Bogdan",90);
        System.out.println(cas.equals(bgd));
        System.out.println(cas.hashCode()==bgd.hashCode());
    }

}

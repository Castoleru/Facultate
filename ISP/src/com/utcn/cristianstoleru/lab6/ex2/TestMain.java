package com.utcn.cristianstoleru.lab6.ex2;

import com.utcn.cristianstoleru.lab6.ex1.BankAccount;

public class TestMain {
    public static void main(String[] args) {
        Bank bankAccount=new Bank();
        bankAccount.addAccount("tata",30312);
        bankAccount.addAccount("tata2",310);
        bankAccount.addAccount("tata3",320);
        bankAccount.addAccount("Ovi",414214);
        bankAccount.addAccount("Dan",1231);
        bankAccount.addAccount("Cas",4124);
        bankAccount.addAccount("dada",42143);
        bankAccount.addAccount("wqa",231);

        bankAccount.printAccounts();
        System.out.println("------------------------------------");
        bankAccount.printAccounts(1000,4000);
        System.out.println("------------------------------------");
        BankAccount ovi=bankAccount.getAccount("Ovi");
        System.out.println("------------------------------------");
        System.out.println(ovi.toString());
        System.out.println("------------------------------------");

    }
}

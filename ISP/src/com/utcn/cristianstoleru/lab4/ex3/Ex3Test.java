package com.utcn.cristianstoleru.lab4.ex3;

import com.utcn.cristianstoleru.lab4.ex2.Author;


public class Ex3Test {
    public static void main(String[] args) {
        Author a = new Author("Maria", "email@user.com", 'f');
        Book b = new Book("Casa", a, 23);
        Book b2 = new Book("masa", a, 45, 2);
        b.setQtyInStock(5);
        System.out.println(b.getAuthor().toString() + ' ' + b.getName() + ' ' + b.getPrice() + ' ' + b.getQtyInStock());
    }
}

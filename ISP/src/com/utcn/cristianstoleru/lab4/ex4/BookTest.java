package com.utcn.cristianstoleru.lab4.ex4;

import com.utcn.cristianstoleru.lab4.ex2.Author;

import java.util.Arrays;

public class BookTest {
    public static void main(String[] args) {
        Author[] aut = new Author[3];
        aut[0] = new Author("Teo1", "teo", 'f');
        aut[1] = new Author("Teo2", "teo", 'f');
        aut[2] = new Author("Teo3", "teo", 'f');
        Book b = new Book("cas", aut, 32, 4);
        System.out.println(b.toString() + "\n");
        b.setPrice(45);
        b.setQtyInStock(56);
        b.printAuthors();
        System.out.println(Arrays.toString(b.getAuthor()) + " " + b.getName() + " " + b.getPrice() + " " + b.getQtyInStock());
    }
}

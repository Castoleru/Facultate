package com.utcn.cristianstoleru.lab4.ex2;

public class AuthorTest {
    public static void main(String[] args) {
        Author a = new Author("Cristian Stoleru", "cas@gmail.com", 'm');
        a.setEmail("castoleru@gmail.com");
        System.out.println(a.getEmail() + " " + a.getName() + " " + a.toString());
    }
}

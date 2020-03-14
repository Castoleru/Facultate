package com.utcn.cristianstoleru.lab3.ex3;

import javax.lang.model.element.NestingKind;

public class Author {
    String name;
    String email;
    char gender;

    Author(String n, String e, char g) {
        name = n;
        email = e;
        gender = g;
    }

    public String getName() {
        return name;
    }

    public String getEmail() {
        return email;
    }

    public char getGender() {
        return gender;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public String toString() {
        return "Author-name " + name + "(" + gender + ") at email " + email;
    }
}

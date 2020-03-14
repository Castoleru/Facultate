package com.utcn.cristianstoleru.lab6.ex3;

public class Definittion {
    private String description;

public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Definittion(String description) {
        this.description = description;
    }
    @Override
    public String toString() {
        return "Definittion{" +
                "description='" + description + '\'' +
                '}';
    }


}

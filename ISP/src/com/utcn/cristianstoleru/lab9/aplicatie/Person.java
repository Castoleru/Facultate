package com.utcn.cristianstoleru.lab9.aplicatie;

public class Person {
    private String id;
    private String fn;
    private String ln;

    public Person(String id, String fn, String ln) {
        this.id = id;
        this.fn = fn;
        this.ln = ln;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getFn() {
        return fn;
    }

    public void setFn(String fn) {
        this.fn = fn;
    }

    public String getLn() {
        return ln;
    }

    public void setLn(String ln) {
        this.ln = ln;
    }
}

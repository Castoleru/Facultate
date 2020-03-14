package com.utcn.cristianstoleru.lab6.ex3;

import java.util.HashMap;
import java.util.Iterator;

public class Dictionary {
    private HashMap<Word,Definittion> dictionary= new HashMap<>();

    public Dictionary() {
    }

    public Dictionary(HashMap<Word, Definittion> dictionary) {
        this.dictionary = dictionary;
    }
    public void addWord(Word w, Definittion d){
        this.dictionary.put(w,d);
    }
    public Definittion getDefinition(Word w){
        return  dictionary.get(w);
    }
    public void getAllWords()
    {
        Iterator iterator=dictionary.keySet().iterator();
        while (iterator.hasNext())
        {
            System.out.println(iterator.next());
        }
    }
    public void  getAllDefinition(){
        Iterator iterator=dictionary.keySet().iterator();
        Iterator iterator2=dictionary.entrySet().iterator();
        while (iterator.hasNext())
        {
            System.out.println(iterator.next()+" : "+iterator2.next());
        }
    }
}
package com.utcn.cristianstoleru.lab9.aplicatie;

import javax.swing.*;

public class MainFrame {
    public static void main(String[] args) {
        JFrame f= new JFrame("Aplicatie");
        f.setLayout(null);
        f.setSize(300,400);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        int w=80,h=20;

        JLabel id= new JLabel("ID");
        id.setBounds(10,50,w,h);
        f.add(id);

        JLabel fn= new JLabel("First Name");
        fn.setBounds(10,100,w,h);
        f.add(fn);

        JLabel ln= new JLabel("Last Name");
        ln.setBounds(10,150,w,h);
        f.add(ln);

        JTextField idT = new JTextField();
        idT.setBounds(100,50,w,h);
        f.add(idT);

        JTextField fnT = new JTextField();
        fnT.setBounds(100,100,w,h);
        f.add(fnT);

        JTextField lnT = new JTextField();
        lnT.setBounds(100,150,w,h);
        f.add(lnT);

        f.setVisible(true);

    }
}

package com.utcn.cristianstoleru.lab10.aplicatie;

import javax.swing.*;
import java.awt.*;

public class Window extends JFrame {
    private JButton jButton1;
    private JButton jButton2;
    private JTextField jTextField1;
    private JTextField jTextField2;
    private JTextArea jTextArea;

    public Window() throws HeadlessException {
        setTitle("Threads and Swing");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(null);
        setVisible(true);
        //setSize(200,320);
        setBounds(600,400,200,320);

        jButton1=new JButton("Butonul 1");
        jButton1.setBounds(10,10,80,50);
        jButton2=new JButton("Butonul 2");
        jButton2.setBounds(100,10,80,50);
        jTextField1=new JTextField();
        jTextField1.setBounds(10,70,80,80);
        jTextField2=new JTextField();
        jTextField2.setBounds(100,70,80,80);
        jTextArea=new JTextArea();
        jTextArea.setBounds(10,160,170,100);

        add(jButton1);add(jButton2);add(jTextField1);add(jTextField2);add(jTextArea);

        revalidate();
        repaint();

        jButton1.addActionListener(e->{
            new Thread(()->{
                int count=0;
                while (true){
                    count++;
                    jTextField1.setText(String.valueOf(count));
                    jTextArea.setText(jTextArea.getText()+"\n Laborator ISP");
                    try {
                        Thread.sleep(1000);
                    } catch (InterruptedException e1) {
                        e1.printStackTrace();
                    }
                }
            }).start();
        });
        jButton2.addActionListener(e->{
            new Thread(()->{
               while (true){
                   jTextField2.setText(String.valueOf((int)(Math.random()*100)));
                   jTextArea.setText("\0");
                   jTextArea.setText(jTextArea.getText()+"Cristian-Andrei Stoleru e mare mafiot");

                   try {
                       Thread.sleep(3000);
                   } catch (InterruptedException e1) {
                       e1.printStackTrace();
                   }
               }
            }).start();
        });

    }
}

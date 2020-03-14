package com.utcn.cristianstoleru.lab10.ex6;

import javax.swing.*;

public class Window extends JFrame {
    private JButton jButton1;
    private JButton jButton2;
    private JTextField jTextField;
    private int counter=0;
    private Thread thread;

    public Window(){
        setTitle(" chronometer ");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(null);
        this.setSize(250, 250);
        this.setVisible(true);
        jButton1=new JButton("Start");
        jButton1.setBounds(10,10,80,60);
        jButton2=new JButton("Stop");
        jButton2.setBounds(10,100,80,60);
        jTextField=new JTextField();
        jTextField.setBounds(100,10,100,60);
        add(jTextField);
        add(jButton1);
        add(jButton2);
        revalidate();
        repaint();

        jButton1.addActionListener(e->{
            thread=new Thread(()->{
                while (true) {
                    jTextField.setText(String.valueOf(counter));
                    try {
                        Thread.sleep(1000);
                    } catch (InterruptedException ee) {
                        ee.printStackTrace();
                    }
                    counter++;
                    revalidate();
                    repaint();
                }
            });
            thread.start();
        });
        jButton2.addActionListener(e->{
            thread.stop();
        });


    }
}

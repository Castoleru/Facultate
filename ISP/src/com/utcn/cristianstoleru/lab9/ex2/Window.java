package com.utcn.cristianstoleru.lab9.ex2;

import javax.swing.*;

public class Window extends JFrame {
    private JButton bCount;
    private JTextField jt;
    private int count = 0;

    Window() {
        setTitle("Button Counter");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(null);
        this.setSize(250, 250);
        this.setVisible(true);
        bCount = new JButton("Click me!");
        bCount.setBounds(10, 50, 100, 80);
        jt = new JTextField();
        jt.setBounds(150, 50, 80, 80);
        this.add(jt);
        this.add(bCount);
        countRead();
        bCount.addActionListener(e -> {
            count++;
            countRead();
        });
    }
    private void countRead(){
        jt.setText(String.valueOf(count));
        this.repaint();
    }
}

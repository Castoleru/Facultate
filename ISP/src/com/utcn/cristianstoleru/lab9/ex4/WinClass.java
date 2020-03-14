package com.utcn.cristianstoleru.lab9.ex4;

import javax.swing.*;

public class WinClass extends JFrame {
    private String win;
    private JLabel label = new JLabel();
    private JButton replay= new JButton();
    WinClass() {
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(null);
        setTitle("Castigator");
        setSize(200, 300);
        setVisible(false);
        setLocation(650,150);
        revalidate();
        repaint();
    }

    public void WindowOpen()
    {
        label.setText(win + " has won");
        label.setBounds(20, 10, 80, 80);
        replay.setText("Replay");
        replay.setBounds(30,90,80,80);
        replay.addActionListener(e->{
            X0app x0= new X0app();
            this.setVisible(false);
            this.dispose();
        });
        add(label);add(replay);
        this.setVisible(true);
        revalidate();
        repaint();
    }
    public String getWin() {
        return win;
    }

    public void setWin(String win) {
        this.win = win;
    }
}

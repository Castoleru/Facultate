package com.utcn.cristianstoleru.lab9.ex4;

import javax.swing.*;
import java.awt.*;

public class X0app extends JFrame {
    private JButton b11;
    private JButton b12;
    private JButton b13;
    private JButton b21;
    private JButton b22;
    private JButton b23;
    private JButton b31;
    private JButton b32;
    private JButton b33;
    private int count = 0;


    public X0app() {

        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(3, 3));
        setSize(550, 850);
        setVisible(true);
        setTitle(" X si 0");
        setLocation(650,150);

        b11 = buttonAlloc();
        b12 = buttonAlloc();
        b13 = buttonAlloc();

        b21 = buttonAlloc();
        b22 = buttonAlloc();
        b23 = buttonAlloc();

        b31 = buttonAlloc();
        b32 = buttonAlloc();
        b33 = buttonAlloc();

        revalidate();
        repaint();

        b11.addActionListener(e -> {
            buttonSet(b11);
        });
        b12.addActionListener(e -> {
            buttonSet(b12);
        });
        b13.addActionListener(e -> {
            buttonSet(b13);
        });

        b21.addActionListener(e -> {
            buttonSet(b21);
        });
        b22.addActionListener(e -> {
            buttonSet(b22);
        });
        b23.addActionListener(e -> {
            buttonSet(b23);
        });

        b31.addActionListener(e -> {
            buttonSet(b31);
        });
        b32.addActionListener(e -> {
            buttonSet(b32);
        });
        b33.addActionListener(e -> {
            buttonSet(b33);
        });

    }

    private void close() {
        if (win() != null) {
            WinClass wc = new WinClass();
            wc.setWin(win());
            wc.WindowOpen();
            this.setVisible(false);
            this.dispose();
        }
        if (count == 8) {
            reset();
        }
    }

    private void reset() {
        JButton bt = new JButton();
        b11.setText(bt.getText());
        b12.setText(bt.getText());
        b13.setText(bt.getText());

        b21.setText(bt.getText());
        b22.setText(bt.getText());
        b23.setText(bt.getText());

        b31.setText(bt.getText());
        b32.setText(bt.getText());
        b33.setText(bt.getText());

        bEnable(b11);
        bEnable(b12);
        bEnable(b13);
        bEnable(b21);
        bEnable(b22);
        bEnable(b23);
        bEnable(b31);
        bEnable(b32);
        bEnable(b33);
        count = 0;


    }

    private void bEnable(JButton button) {
        button.setEnabled(true);
        repaint();
    }

    private String win() {
        JButton bt = new JButton();
        if (b11.getText().equals(bt.getText()) || b22.getText().equals(bt.getText()) || b33.getText().equals(bt.getText()))
            return null;
        if ((b11.getText().equals(b12.getText()) && b11.getText().equals(b13.getText())) || (b11.getText().equals(b22.getText())) && (b11.getText().equals(b33.getText())))
            return b11.getText();
        if (b21.getText().equals(b22.getText()) && b21.getText().equals(b23.getText())) return b21.getText();
        if (b31.getText().equals(b32.getText()) && b31.getText().equals(b33.getText())) return b31.getText();
        if (b13.getText().equals(b22.getText()) && b13.getText().equals(b31.getText())) return b11.getText();
        if (b11.getText().equals(b21.getText()) && b11.getText().equals(b31.getText())) return b11.getText();
        if (b22.getText().equals(b12.getText()) && b22.getText().equals(b32.getText())) return b22.getText();
        if (b33.getText().equals(b13.getText()) && b33.getText().equals(b23.getText())) return b33.getText();

        return null;
    }

    private String buttonXOr0(int num) {
        if (num % 2 == 0) return "X";
        else return "0";
    }

    private void buttonSet(JButton button) {
        if (button == null)
            button = new JButton();
        button.setText(buttonXOr0(count));
        button.setEnabled(false);
        repaint();
        close();
        count++;
    }

    private JButton buttonAlloc() {
        JButton button = new JButton();
        add(button);
        return button;
    }

}

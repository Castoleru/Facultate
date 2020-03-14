package com.utcn.cristianstoleru.lab9.ex3;

import javax.swing.*;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

public class FileRWrite extends JFrame {
    private JButton jButton;
    private JTextField jTextFieldRead;
    private JTextField jTextFieldWrite;

    public FileRWrite ()
    {
        setTitle("File Reader");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(null);
        setSize(550, 850);
        setVisible(true);
        jButton = new JButton("Click me!");
        jButton.setBounds(10, 50, 100, 80);
        jTextFieldRead = new JTextField();
        jTextFieldRead.setBounds(10, 150, 520, 100);
        jTextFieldWrite = new JTextField();
        jTextFieldWrite.setBounds(10, 250, 520, 200);
        add(jButton);add(jTextFieldRead);add(jTextFieldWrite);
        repaint();

        jButton.addActionListener(e->{
            String fileName;
            fileName=jTextFieldRead.getText();
            String data = "";
            try {
                data = new String(Files.readAllBytes(Paths.get(fileName)));
            } catch (IOException e1) {
                e1.printStackTrace();
            }
            jTextFieldWrite.setText(data);
        });

    }

}

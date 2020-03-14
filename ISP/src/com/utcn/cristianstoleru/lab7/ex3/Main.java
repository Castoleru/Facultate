package com.utcn.cristianstoleru.lab7.ex3;

import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader in = new BufferedReader(new FileReader("D:\\School\\java\\isp-laborator\\src\\com\\utcn\\cristianstoleru\\lab7\\ex3\\TopSecret.dec"));
        BufferedWriter out = new BufferedWriter(new FileWriter("D:\\School\\java\\isp-laborator\\src\\com\\utcn\\cristianstoleru\\lab7\\ex3\\TopSecret.enc"));
        try {
            //---------------------------------------------------------------- Citire fisier intreg
            StringBuilder sb = new StringBuilder();
            String line = in.readLine();

            while (line != null) {
                sb.append(line);
                sb.append(System.lineSeparator());
                line = in.readLine();
            }
            String fileString = sb.toString();
            //---------------------------------------------------------------- Sfarsit citire fisier
            int n=fileString.length();
            char[] fileChars=fileString.toCharArray();
            for(int i=0;i<n;i++)
            {
                fileChars[i]<<=1;
            }
            String encripted= new String(fileChars);
            out.write(encripted);
        } finally {
            in.close();
            out.close();
        }
    }
}

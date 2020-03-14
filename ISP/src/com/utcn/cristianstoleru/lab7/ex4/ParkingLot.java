package com.utcn.cristianstoleru.lab7.ex4;

import java.io.*;
import java.util.HashMap;

public class ParkingLot {

    void parkCar(HashMap<String,Car> c, String storeRecipientName) throws IOException {
        ObjectOutputStream o =
                new ObjectOutputStream(
                        new FileOutputStream(storeRecipientName));

        o.writeObject(c);
    }
    HashMap<String,Car> checkCar(String storeRecipientName) throws IOException, ClassNotFoundException{
        ObjectInputStream in =
                new ObjectInputStream(
                        new FileInputStream(storeRecipientName));
        HashMap x = (HashMap) in.readObject();
        return x;
    }
}

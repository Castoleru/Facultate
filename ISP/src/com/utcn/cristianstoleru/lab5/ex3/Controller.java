package com.utcn.cristianstoleru.lab5.ex3;


public class Controller {
    TemperatureSensor tempSensor = new TemperatureSensor();
    LightSensor lightSensor = new LightSensor();

    public void control() {
        int i = 0;
        while (i < 20) {
            try {
                Thread.sleep(1000);
                System.out.println((i+1)+" Measurement");
                System.out.println("Temperature is: " + tempSensor.readValue());
                System.out.println("Distance is: " + lightSensor.readValue());
                System.out.println("------------------------------------------");
                i++;
            } catch (InterruptedException ex) {
                Thread.currentThread().interrupt();
            }

        }
    }
}

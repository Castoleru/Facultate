package com.utcn.cristianstoleru.lab5.ex4;


public class Controller {
    private static volatile Controller instance = null;
    private TemperatureSensor tempSensor = new TemperatureSensor();
    private LightSensor lightSensor = new LightSensor();

    private Controller() {

    }

    public static Controller getInstance() {
        if (instance == null) {
            instance = new Controller();
        }
        return instance;
    }

    public void control() {
        int i = 0;
        while (i < 20) {
            try {
                Thread.sleep(1000);
                System.out.println((i + 1) + " Measurement");
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

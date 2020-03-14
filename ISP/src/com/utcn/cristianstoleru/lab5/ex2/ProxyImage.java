package com.utcn.cristianstoleru.lab5.ex2;

public class ProxyImage implements Image {

    private RealImage realImage;
    private String fileName;
    private RotatedImage rotatedImage;
    private boolean rotated = false;

    public ProxyImage(String fileName, boolean rotated) {
        this.fileName = fileName;
        this.rotated = rotated;
    }

    @Override
    public void display() {
        if (!this.rotated) {
            if (realImage == null) {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        } else {
            if (rotatedImage == null) {
                rotatedImage = new RotatedImage(fileName);
            }
            rotatedImage.display();

        }

    }
}

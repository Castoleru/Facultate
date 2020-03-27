package Lab3;

public class Main {

    public static void main(String[] args) {
        Object P8= new Object();
        Fir1 fir1= new Fir1(P8);
        Fir2 fir2= new Fir2(P8);
        fir1.start();
        fir2.start();
    }
}

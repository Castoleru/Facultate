package Lab3.problema4;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        Object P10 = new Object();
        Object P6 = new Object();
        Fir1 fir1 = new Fir1(P10, P6);
        Fir2 fir2 = new Fir2(P10, P6);
        Fir3 fir3 = new Fir3(P10, P6);
        fir1.start();
        fir2.start();
        fir3.start();
        fir1.join();
        fir2.join();
        fir3.join();


    }
}

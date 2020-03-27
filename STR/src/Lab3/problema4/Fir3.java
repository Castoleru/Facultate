package Lab3.problema4;
public class Fir3 extends Thread {
    private Object P10;
    private Object P6;

    public Fir3(Object p10, Object p6) {
        P10 = p10;
        P6 = p6;
    }

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public void run() {
        System.out.println("P7");

        synchronized (P10)
        {
            try {
                P10.wait();

            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        int k = randAB(3, 5);
        for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
            i++;
            i--;
        }
        System.out.println("P8");
        System.out.println("P9");

    }
}
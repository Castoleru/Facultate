package Lab3.problema3;

public class Fir2 extends Thread {
    private Object P8;

    public Fir2(Object p8) {
        P8 = p8;
    }

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public void run() {
        while (true) {
            System.out.println("P0");
            synchronized (P8) {
                int k = randAB(4, 7);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;
                }
                System.out.println("P1");

            }
            System.out.println("P2");
            try {
                Thread.sleep(3000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            System.out.println("P3");
        }
    }
}

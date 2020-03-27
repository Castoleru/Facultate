package Lab3.problema3;

public class Fir1 extends Thread {
    private Object P8;

    public Fir1(Object p8) {
        P8 = p8;
    }

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public void run() {
        while (true) {
            System.out.println("P17");
            synchronized (P8) {
                int k = randAB(3, 6);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;
                }
                System.out.println("P18");

            }
            System.out.println("P19");
            try {
                Thread.sleep(5000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            System.out.println("P20");
        }
    }
}

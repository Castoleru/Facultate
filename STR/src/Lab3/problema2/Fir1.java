package Lab3.problema2;

public class Fir1 extends Thread {
    private Object P9;
    private Object P10;
    private Object P20;

    public Fir1(Object p9, Object p10, Object p20) {
        P9 = p9;
        P10 = p10;
        P20 = p20;
    }

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public void run() {
        int k = randAB(2, 4);
        for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
            i++;
            i--;
        }
        System.out.println("P1");
       /* synchronized (P9) {
            k = randAB(4, 6);
            for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                i++;
                i--;
            }
            System.out.println("P4");
            synchronized (P10) {
                System.out.println("P6");
                try {
                    Thread.sleep(4000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }

        }*/
        synchronized (P20) {
            synchronized (P9) {
                k = randAB(4, 6);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;
                }
                System.out.println("P4");

                synchronized (P10) {
                    System.out.println("P6");
                    try {
                        Thread.sleep(4000);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            }
        }


        System.out.println("P7");
    }
}

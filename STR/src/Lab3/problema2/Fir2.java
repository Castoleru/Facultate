package Lab3.problema2;

public class Fir2 extends Thread {
    private Object P20;
    private Object P9;
    private Object P10;

    public Fir2(Object p20, Object p9, Object p10) {
        P20 = p20;
        P9 = p9;
        P10 = p10;
    }

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public void run() {
        int k = randAB(3, 5);
        for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
            i++;
            i--;
        }
        System.out.println("P2");
        /*synchronized (P10){
             k = randAB(5, 7);
            for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                i++;
                i--;
            }
            System.out.println("P3");
            synchronized (P9){
                System.out.println("P5");
                try {
                    Thread.sleep(5000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }*/
        synchronized (P20) {
            synchronized (P10) {
                k = randAB(5, 7);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;
                }
                System.out.println("P3");
                synchronized (P9) {
                    System.out.println("P5");
                    try {
                        Thread.sleep(5000);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            }
        }
        System.out.println("P8");
    }
}



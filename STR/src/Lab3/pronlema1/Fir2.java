package Lab3.pronlema1;

public class Fir2 extends Thread{
    private Object P9;
    private Object P10;

    private int randAB(int a, int b) {
        return (int) (Math.random() * Math.abs(b - a + 1) + Math.min(a, b));
    }

    public Fir2(Object p9, Object p10) {
        P9 = p9;
        P10 = p10;
    }

    public void run() {

        try {
            //p11
            System.out.println("P11");
            //p4
            synchronized (P9) {
                synchronized (P10) {
                    int k = randAB(3, 6);
                    for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                        i++;
                        i--;

                    }
                    System.out.println("P12");
                    Thread.sleep(3000);
                }
            }
            //p6
            System.out.println("P13");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

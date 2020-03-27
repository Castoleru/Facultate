package Lab3.pronlema1;

public class Fir1 extends Thread {
    private Object P9;
    private int randAB(int a, int b)
    {
        return (int)(Math.random()*Math.abs(b-a+1)+Math.min(a,b));
    }

    public Fir1(Object p9) {
        P9 = p9;
    }

    public void run(){

        try {
            //p1
            System.out.println("P1");
            //p4
            synchronized (P9){
                int k = randAB(2, 4);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;

                }
                System.out.println("P4");
                Thread.sleep(4000);
            }
            //p6
            System.out.println("P6");
        }catch (Exception e)
        {
            e.printStackTrace();
        }
    }
}

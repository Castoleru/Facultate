package Lab3.pronlema1;

public class Fir3 extends Thread{
    private Object P10;
    private int randAB(int a, int b)
    {
        return (int)(Math.random()*Math.abs(b-a+1)+Math.min(a,b));
    }

    public Fir3(Object p9) {
        P10 = p9;
    }

    public void run(){

        try {
            //p1
            System.out.println("P2");
            //p4
            synchronized (P10){
                int k = randAB(2, 5);
                for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                    i++;
                    i--;
                }
                System.out.println("P3");
                Thread.sleep(5000);
            }
            //p6
            System.out.println("P5");
        }catch (Exception e)
        {
            e.printStackTrace();
        }
    }
}

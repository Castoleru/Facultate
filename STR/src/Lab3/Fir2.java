package Lab3;

public class Fir2 extends Thread {
    Object P8;
    Fir2(Object P8){
        this.P8=P8;
    }
    private int randAB(int a, int b)
    {
        return (int)(Math.random()*Math.abs(b-a+1)+Math.min(a,b));
    }
    public void run()
    {
        //p2
        System.out.println("P3");
        try {
            Thread.sleep((randAB(2,4)*1000));
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        //p4
        System.out.println("P5");
        synchronized (P8) {
            //p6
            int k = randAB(3, 6);
            for (int i = 0; i < k * 0.64 * Math.pow(10, 8); i++) {
                i++;
                i--;
            }
        }
        System.out.println("P7");
        //p9
        System.out.println("P10");

    }
}

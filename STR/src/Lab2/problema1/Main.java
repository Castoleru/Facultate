package Lab2.problema1;

public class Main {
    private static int randAB(int a, int b)
    {
        return (int)(Math.random()*Math.abs(b-a+1)+Math.min(a,b));
    }
    public static void main(String[] args) {
        System.out.println(randAB(10,14));
        System.out.println(randAB(11,11));
        System.out.println(randAB(20,2));
        System.out.println(randAB(32,14));


    }
}

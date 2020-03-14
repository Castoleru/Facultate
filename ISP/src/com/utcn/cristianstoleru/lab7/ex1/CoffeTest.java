package com.utcn.cristianstoleru.lab7.ex1;

public class CoffeTest {
    public static void main(String[] args) {
        CofeeMaker mk = new CofeeMaker();
        CofeeDrinker d = new CofeeDrinker();

        for (int i = 0; i < 15; i++) {
            Cofee c = mk.makeCofee();
            try {
                d.drinkCofee(c);
            } catch (OutOfNumberException e) {
                System.out.println("Exception: " + e.getMessage() + " number of coffe= " + e.getNumber());
            }catch (TemperatureException e) {
                System.out.println("Exception: " + e.getMessage() + " temp=" + e.getTemp());
            } catch (ConcentrationException e) {
                System.out.println("Exception: " + e.getMessage() + " conc=" + e.getConc());
            }
             finally {
                System.out.println("Throw the cofee cup.\n");
            }
        }
    }
}
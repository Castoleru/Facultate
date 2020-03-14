package com.utcn.cristianstoleru.lab7.ex1;

class CofeeDrinker{
    void drinkCofee(Cofee c) throws TemperatureException, ConcentrationException, OutOfNumberException{
        if(Cofee.numberCofee>10)
            throw new OutOfNumberException(Cofee.getNumberCofee(),"Out of coffee");
        if(c.getTemp()>60)
            throw new TemperatureException(c.getTemp(),"Cofee is to hot!");
        if(c.getConc()>50)
            throw new ConcentrationException(c.getConc(),"Cofee concentration to high!");
        System.out.println("Drink cofee:"+c);
    }
}
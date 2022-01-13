using System;
namespace Test{

interface Vehicle {
		
	void changeGear(int a);
	void speedUp(int a);
	void applyBrakes(int a);
}

class Car : Vehicle{
	
	int speed;
	int gear;
	public void changeGear(int newGear)
	{
		
		gear = newGear;
	}
	
	public void speedUp(int increment)
	{
		
		speed = speed + increment;
	}
	public void applyBrakes(int decrement)
	{
		
		speed = speed - decrement;
	}
	
	public void printStates()
	{
		Console.WriteLine("speed: " + speed +
						" gear: " + gear);
	}
}

class Bike : Vehicle {
	
	int speed;
	int gear;
	
	public void changeGear(int newGear)
	{
		
		gear = newGear;
	}
	
	public void speedUp(int increment)
	{
		
		speed = speed + increment;
	}
	public void applyBrakes(int decrement){
		
		speed = speed - decrement;
	}
	
	public void printStates()
	{
		Console.WriteLine("speed: " + speed +
						" gear: " + gear);
	}
	
}
}








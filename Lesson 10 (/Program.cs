using Lesson_10__;

Console.WriteLine("*****Fun with class types****");

//размещаем в памяти и конфигурируем обьект Car

Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

//увеличить скорость авто в нескольско раз и вывести новое состояние 
for (int i = 0; i < 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Console.ReadLine(); 

//вызов стандартного конструктора chuck
Car chuck = new Car();

//выводит строку "Chuck is going 10 MPH"
chuck.PrintState();

Console.ReadLine();

//Создать обьект Car по имени Chuck со скоростью 10 
Car chuck2 = new Car();
chuck.PrintState();

//создать обьект Car по имени Mary со скоростью 0 
Car mary = new Car("Mary");
mary.PrintState();

//Создать обьект по имени Daisy со скоротью 75 
Car daisy = new Car("Daisy", 75);
daisy.PrintState();

Console.ReadLine();

//создание экземпляра класса Moto
Console.WriteLine("****8Fun with Class types*****");
MotorCycle mc = new MotorCycle();
mc.PopAWheely();

Console.ReadLine();

//создаем обьект MotorCycle с мотоциклистом по имени Tiny
MotorCycle c = new MotorCycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.driverName);

Console.ReadLine();

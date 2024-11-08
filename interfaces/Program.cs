
Car myCar = new Tesla();
myCar.color = "white";
myCar.model = "tesla";
myCar.Start();
Console.WriteLine($"My beautiful {myCar.color} {myCar.model}");
myCar.Drive();
myCar.battery=22;
if(myCar.battery<50) myCar.Charge(); 
myCar.Stop();


Car myHCar = new Lexus();
myHCar.color = "black";
myHCar.model = "lexus";
myHCar.Start();
Console.WriteLine($"My beautiful {myHCar.color} {myHCar.model}");
myHCar.Drive();
myHCar.battery=59;

if(myHCar.battery<60) myHCar.Charge(); 

myHCar.Stop();

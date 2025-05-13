using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using ReflectionTutorial;

/*var car = new Car("Toyota", "Corolla", 50, 6.0);

Console.WriteLine($"Cars made so far {Car.CarsMade}");

car.AddFuel(20);
car.AddFuel(70);

car.Drive(100);
car.AddFuel(200);*/
var data = File.ReadAllText("car.txt").Split(";");
var brand = data[0];
var model = data[1];
var tankCapacity = int.Parse(data[2]);
var fuelConsumption = double.Parse(data[3]);
var fuelLevel = int.Parse(data[4]);
var odometer = int.Parse(data[5]);

var car = new Car(brand, model, tankCapacity, fuelConsumption);

var carType = typeof(Car);
var fuelLevelField = carType.GetField("_fuelLevel", BindingFlags.NonPublic | BindingFlags.Instance);
var odometerField = carType.GetField("_odometer", BindingFlags.NonPublic | BindingFlags.Instance);

fuelLevelField.SetValue(car, fuelLevel);
odometerField.SetValue(car, odometer);

Console.WriteLine($"{car.Brand} {car.Model} drove {car.Odometer} kilometres and remainig fuel is {car.FuelLevel}");

//File.WriteAllText("car.txt", $"{car.Brand}; {car.Model}; {car.TankCapacity}; {car.FuelConsumption}; {car.FuelLevel}; {car.Odometer}");
using ReflectionTutorial;
using System.Reflection;

/*var fields = typeof(Car).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

foreach (var field in fields)
    Console.WriteLine(field.Name);*/

/*var methods = typeof(Car).GetMethods(BindingFlags.Public | BindingFlags.Instance);

foreach (var method in methods)
    Console.WriteLine(method.Name);*/

var addFuelMethod = typeof(Car).GetMethod("AddFuel", BindingFlags.Instance | BindingFlags.Public);

Console.WriteLine(addFuelMethod.MemberType);
Console.WriteLine(addFuelMethod.ReturnParameter);
foreach (var parameter in addFuelMethod.GetParameters())
{
    Console.WriteLine(parameter.Name);
    Console.WriteLine(parameter.ParameterType);


}



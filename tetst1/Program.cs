using CustomEnumerator;
using System.Collections;


Console.WriteLine("Custom IEnumerable/IEnumerator \n");

Garage carLot = new Garage();

foreach (Car item in carLot)
    Console.WriteLine($"{item.PetName} is going {item.CurrentSpeed} MPH");


//IEnumerator i = carLot.GetEnumarable
//Console.ReadLine();

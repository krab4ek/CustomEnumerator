using CustomEnumerator;

Console.WriteLine("Custom IEnumerable/IEnumerator \n");

Garage carLot = new Garage();

foreach (Car item in carLot)
    Console.WriteLine($"{item.PetName} is going {item.CurrentSpeed} MPH");

Console.ReadLine();

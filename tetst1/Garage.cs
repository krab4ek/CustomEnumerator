using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator;

public class Garage
{
    private Car[] carArray = new Car[4];
    public Garage()
    {
        carArray[0]=new Car("Rusty",20);
        carArray[1] = new Car("Clunker", 56);
        carArray[2] = new Car("Andy", 45);
        carArray[3] = new Car("Rsty", 29);

    }
}

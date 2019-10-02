using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        List<Wagon> wagons;
        Wagon wagonadd;

        public Train()
        {
            wagons = new List<Wagon>();
            wagonadd = new Wagon();
            wagons.Add(wagonadd);
        }

        public string TrainWagonCycle(Animal animalrd)
        {
            int y = 1;
            int i;

            for (i = 0; i < y; i++)
            {
                if (wagons[i].WagonAdd(animalrd) == true)
                {
                    wagons[i].WagonAdd(animalrd);
                }
                else
                {
                    y++;
                    wagons.Add(wagonadd);
                }
            }

            return string.Format("Animal added to wagon {0}", i + 1);
        }
    }
}

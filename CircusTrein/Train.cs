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

        public List<Wagon> Wagons
        {
            get { return wagons; }
        }

        public Train()
        {
            wagons = new List<Wagon>();
            wagonadd = new Wagon();
            wagons.Add(wagonadd);
        }

        public string TrainWagonCycleAdd(Animal animalrd)
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

            return string.Format("Animal added to {0}", wagons[i].ToString());
        }

        public List<Animal> Wagonanimals(int cycle)
        {
            return wagons[cycle].Animals;
        }
    }
}

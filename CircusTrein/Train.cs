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
        //  string wagonnumb;


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
            wagonadd = new Wagon();
            int y = 1;
            int i;

            for (i = 0; i < y; i++)
            {
                if (wagons[i].WagonAdd(animalrd) == true)
                {
                    wagons[i].Animals.Add(animalrd);
                }
                else if (wagons[i].WagonAdd(animalrd) == false)
                {
                    y++;
                    wagons.Add(wagonadd);
                }
            }

            return string.Format("Animal added to {0}", wagons[i-1].ToString());
        }

        public List<Animal> Wagonanimals(int cycle)
        {
            return wagons[cycle].Animals;
        }

         /* public string TrainWagoncycle(Animal animalrd)
        {
            foreach(Wagon wagon in wagons)
            {
                if(wagon.WagonAdd(animalrd) == false)
                {
                    wagons.Add(wagonadd);
                }
                else if(wagon.WagonAdd(animalrd) == true)
                {
                    wagon.WagonAdd(animalrd);
                    wagonnumb = wagon.ToString();
                    break;
                }
            }

            return string.Format("Animal added to {0}", wagonnumb);
        }
        */
    }
}

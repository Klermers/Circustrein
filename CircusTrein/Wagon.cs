using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        private int currentWagonNumb;
        private static int Wagoncycle = 1;
        private int Wagonroom = 10;
        private List<Animal> animals = new List<Animal>();

        public Wagon()
        {
            currentWagonNumb= Wagoncycle;
            Wagoncycle++;
        }
        public List<Animal> Animals
        {
            get { return this.animals; }
            set { animals = value; }
        }

        public bool CheckCarnivour()
        {
            foreach(var animal in animals)
            {
                if(animal.Type == "Carnivour")
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckSizeHerbivour(Animal checkcarn)
        {
            foreach(var animal in animals)
            {
                if(checkcarn.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckSizeCarnivour(Animal checkherb)
        {
            foreach(var animal in animals)
            {
                if(checkherb.Size <= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool WagonAdd(Animal animalrd)
        {
            if (CheckCarnivour() == true)
            {
                return false;
            }
            else if (CheckCarnivour() == false)
            {
                if(animalrd.Type == "Carnivour")
                {
                    if(CheckSizeHerbivour(animalrd) == false)
                    {
                        return false;
                    }
                    else if(CheckSizeHerbivour(animalrd) == true)
                    {
                        if(Wagonroom + animalrd.Size <= 10)
                        {
                            Wagonroom += animalrd.Size;
                            Animals.Add(animalrd);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if(animalrd.Type == "Herbivour")
                {
                    if (CheckSizeCarnivour(animalrd) == false)
                    {
                        return false;
                    }
                    else if (CheckSizeCarnivour(animalrd) == true)
                    {
                        if (Wagonroom + animalrd.Size <= 10)
                        {
                            Wagonroom += animalrd.Size;
                            Animals.Add(animalrd);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

          return true;
        }

        public override string ToString()
        {
            return "Wagon" + currentWagonNumb.ToString();
        }

    }
}

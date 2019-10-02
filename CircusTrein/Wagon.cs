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
        private int Wagonroom = 0;
        private List<Animal> animals = new List<Animal>();
        public enum Food { Herbivour = 1, Carnivour = 2 }

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
                if(animal.Type == (int)Food.Carnivour)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckSizeHerbivour(Animal checkcarn)
        {
            foreach(var animal in animals)
            {
                if(animal.Size < checkcarn.Size)
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
                if(animal.Type == (int)Food.Carnivour)
                {
                    if (checkherb.Size <= animal.Size)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool AddWagonHerbivore(Animal animalrd)
        {
            if (CheckCarnivour() == true)
            {
                if (CheckSizeCarnivour(animalrd) == true)
                {
                    if (Wagonroom + animalrd.Size <= 10)
                    {
                        Wagonroom += animalrd.Size;
                        Animals.Add(animalrd);
                        return true;
                    }
                }
            }
            else
            {
                if (Wagonroom + animalrd.Size <= 10)
                {
                    Wagonroom += animalrd.Size;
                    Animals.Add(animalrd);
                    return true;
                }
            }
            return false;
        }

        public bool AddWagonCarnivour(Animal animalrd)
        {
            if(CheckCarnivour() == false)
            {
                if (CheckSizeHerbivour(animalrd) == true)
                {
                    if (Wagonroom + animalrd.Size <= 10)
                    {
                        Wagonroom += animalrd.Size;
                        Animals.Add(animalrd);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool WagonAdd(Animal animalrd)
        {
            if(animalrd.Type == (int)Food.Carnivour)
            {
                if(AddWagonCarnivour(animalrd) == true)
                {
                    return true;
                }
            }
            else
            {
                if (AddWagonCarnivour(animalrd) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Wagon" + currentWagonNumb.ToString();
        }

    }
}

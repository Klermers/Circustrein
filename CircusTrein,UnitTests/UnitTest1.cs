using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void CheckCarnivour_animalTypeCarnivour_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal TestAnimal = new Animal("Lion", 3, "Carnivour");
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(TestAnimal);
            wagon.Animals = animals;
            var result =  wagon.CheckCarnivour();
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckCarnivour_animalTypeNoCarnivour_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();

            //Act
            var result = wagon.CheckCarnivour();
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void CheckSizeHerbivour_checkcarnSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal animal = new Animal("Lion", 3, "Herbivour");
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal);
            wagon.Animals = animals;
            var result = wagon.CheckSizeHerbivour(animal);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckSizeHerbivour_checkcarnSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, "Carnivour");
            Animal animal2 = new Animal("Lion", 3, "Herbivour");
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
            wagon.Animals = animals;
            var result = wagon.CheckSizeHerbivour(carnanimal);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckSizeCarnivour_checkherbSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, "Carnivour");
            Animal checkherb = new Animal("Lion", 3, "Herbivour");
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = wagon.CheckSizeHerbivour(carnanimal);

            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckSizeCarnivour_checkherbSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 10, "Carnivour");
            Animal checkherb = new Animal("Lion", 3, "Herbivour");
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = wagon.CheckSizeHerbivour(checkherb);

            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void Wagonadd_AnimalsAdd_Returnfalse()
        {
            //Arange

            //Act

            //Assert
        }
    }
}

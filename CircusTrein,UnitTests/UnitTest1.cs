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
        public void CheckCarnivour_animalTypeCarnivour_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal TestAnimal = new Animal("Lion", 3, 2);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(TestAnimal);
            wagon.Animals = animals;
            var result =  wagon.CheckCarnivour();
            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void CheckCarnivour_animalTypeNoCarnivour_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();

            //Act
            var result = wagon.CheckCarnivour();
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckSizeHerbivour_checkcarnSize_Returnfalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal animal = new Animal("Zebra", 3, 1);
            Animal animal2 = new Animal("Zebra", 1, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(animal2);
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
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal animal2 = new Animal("Zebra", 3, 1);
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
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = wagon.CheckSizeCarnivour(carnanimal);

            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CheckSizeCarnivour_checkherbSize_Returntrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal carnanimal = new Animal("Lion", 1, 2);
            Animal checkherb = new Animal("Zebra", 3, 1);
            List<Animal> animals = new List<Animal>();

            //Act
            animals.Add(carnanimal);
            wagon.Animals = animals;
            var result = wagon.CheckSizeCarnivour(checkherb);

            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void AddWagonHerbivour_CheckSizeWagon_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            var result =  wagon.AddWagonHerbivore(checkherb);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddWagonHerbivour_CheckSizeWagon_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkherb = new Animal("Zebra", 3, 1);
            //Act
            wagon.AddWagonHerbivore(checkherb);
            wagon.AddWagonHerbivore(checkherb);
            wagon.AddWagonHerbivore(checkherb);
            var result = wagon.AddWagonHerbivore(checkherb);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddWagonCarnivour_CheckSizeWagon_ReturnTrue()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 1);
            //Act
            var result = wagon.AddWagonCarnivour(checkcarn);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddWagonCarnivour_CheckSizeWagon_ReturnFalse()
        {
            //Arange
            Wagon wagon = new Wagon();
            Animal checkcarn = new Animal("Lion", 3, 1);
            //Act
            wagon.AddWagonCarnivour(checkcarn);
            wagon.AddWagonCarnivour(checkcarn);
            wagon.AddWagonCarnivour(checkcarn);
            var result = wagon.AddWagonCarnivour(checkcarn);
            //Assert
            Assert.IsFalse(result);
        }
    }
}

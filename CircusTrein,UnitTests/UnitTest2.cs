using System.Collections.Generic;
using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class Traintest
    {
        [TestMethod]
        public void TrainWagonAdd_Animalcycle_ReturnString()
        {
            //arrange

            Train train = new Train();
            Animal animalrd = new Animal("Zebra", 3, 1);

            //act

            var result = train.TrainWagonCycleAdd(animalrd);

            //assert

            Assert.IsNotNull(result);
        }
    }
}

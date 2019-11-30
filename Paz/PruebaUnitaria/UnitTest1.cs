using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paulo;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void saveTest()
        {
            //Organizar 
            Person Juan = new Person("Perez", 500);
            double valoresperado = 600;

            //Actuar
            Juan.Save(100);
            double valorobtenido = Juan.SaveMoney;

            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
            
        }
        [TestMethod]
        public void spendTest()
        {


            //Organizar 
            Person Juan = new Person("Perez", 500);
            double valoresperado = 400;

            //Actuar
            Juan.Spend(100);
            double valorobtenido = Juan.SaveMoney;

            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);

        }
        [TestMethod]
        public void changeNameTest()
        {

            //Organizar 
            Person Juan = new Person("Perez",500);
            string valoresperado = "Suarez";

            //Actuar
            Juan.ChangeName("Suarez");
            string valorobtenido = Juan.Name;
           //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }

    }
}

using System;
using System.IO;
using NUnit.Framework;

namespace PrintApps
{
    public class PrinterTest
    {

        private readonly StringWriter Sw = new StringWriter();
        private readonly String expected = "Hello World";

        public void SetOut()
        {

            Console.SetOut(Sw);

        }

        public void PrintTest() {

            //Arrange
           
             Printer printer = new Printer();
            
            //Act
            printer.print(expected);

            //Assert

            Assert.AreEqual(expected, Sw.ToString().Trim());

        }




        public void PrintTest2()
        {

            //Arrange

            Printer printer = new Printer();
            String[] expectedArray = { "Hello","World" };
            //Act


            printer.print(expectedArray);

            //Assert

            Assert.AreEqual(expectedArray, Sw.ToString().Trim());

        }



    }
}

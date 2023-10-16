using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;
using System.IO;

namespace WSUniversalLibtest
{
    [TestClass]
    public class Calculationtest
    {
        private void ReadInputData (string fileName,
                                    out int productType,
                                    out int materialType,
                                    out int count,
                                    out float width,
                                    out float length)
        {
            string path = "..\\..\\..\\..\\TestingData\\"+ fileName;
            string[] data =File.ReadAllLines(path);

            productType = int.Parse(data[0]);
            materialType= int.Parse(data[1]);
            count = int.Parse(data[2]);
            width = float.Parse(data[3]);
            length = float.Parse(data[4]);
        }

        private int ReadOutputData(string fileName)
        {
            string path = "..\\..\\..\\..\\TestingData\\" + fileName;
            string data = File.ReadAllText(path);
            return int.Parse(data);
        }
        
        [TestMethod]
        public void TestMethod1()
        {

            int productType, materialType,count;
            float width, length;
            ReadInputData("InputData_Hard_10.txt",
                                    out productType,
                                    out materialType,
                                    out count,
                                    out width,
                                    out length);
            int expected = ReadOutputData("OutputData_Hard_10.txt");

            int actual = Calculation.GetQuantityForProduct(
                                                productType,
                                                materialType,
                                                count,
                                                width,
                                                length);

            Assert.AreEqual(expected, actual);  
        }
    }
}

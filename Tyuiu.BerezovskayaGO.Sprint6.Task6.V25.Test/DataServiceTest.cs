using Tyuiu.BerezovskayaGO.Sprint6.Task6.V25.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint6\DataSprint6.InPutDataFileTask6V25.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";
            Assert.AreEqual(wait, res);
        }
    }
}
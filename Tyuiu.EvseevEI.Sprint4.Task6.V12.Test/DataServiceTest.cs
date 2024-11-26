using Tyuiu.EvseevEI.Sprint4.Task6.V12.Lib;
namespace Tyuiu.EvseevEI.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var countries = new string[] { "������", "�������", "��������", "���������", "�������", "������", "�������" };
            string[] res = ds.Calculate(countries);
            string[] wait = { "�������", "�������", "�������" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
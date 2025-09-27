using Tyuiu.VariiMN.Sprint1.Task6.V6.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task6.V6.Test
{
    public class Tests
    {

        [Test]
        public void ValidString()
        {
            string strTest = "Привет меня зовут Максим";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "ривет еня овут аксим";
            Assert.AreEqual(wait, res);
        }
    }
}
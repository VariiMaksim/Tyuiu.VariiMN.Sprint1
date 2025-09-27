using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VariiMN.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            string[] strTest = value.Split(' ');
            for (int i = 0; i < strTest.Length; i++)
            {
                if (strTest[i].Length > 1)
                {
                    strTest[i] = strTest[i].Substring(1);
                }
                else if (strTest[i].Length == 1)
                    {
                    strTest[i] = "";
                    }
            }
            return string.Join(" ", strTest);
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AytuvorovTK.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c - 30 < d);
            res[1] = (a + 600 > b) & (c - 30 < d);
            res[2] = (a > b) || (c - 30 < d);
            res[3] = (a > b) && (c + 500 < d);
            res[4] = !(!res[0]);
            res[5] = (a + 300 > b) ^ (c - 300 > d);

            return res;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AytuvorovTK.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
                (x >= 6 && x <= 8 && y >= 5 && y <= 11) ||
                (x >= 9 && x <= 12 && y >= 3 && y <= 7) ||
                (x >= 6 && x <= 12 && y >= 8 && y <= 9) ||
                (x >= 9 && x <= 10 && y >= 10 && y <= 11))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}

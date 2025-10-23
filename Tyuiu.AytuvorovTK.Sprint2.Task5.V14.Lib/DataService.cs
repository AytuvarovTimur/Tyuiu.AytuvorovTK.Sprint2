using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AytuvorovTK.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            int dayO = (d + k - 2) % 7;

            return days[dayO];
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AytuvorovTK.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Восскресенье";
                default: throw new ArgumentException($"номер дня должен быть от 1 до 7 {value}");
            }
        }
    }
}

namespace la_mia_pizzeria_razor_layout.Models
{
    public class DateT
    {
        public string getDateHour()
        {
            DateTime timeCurrent = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string dateHour = timeCurrent.ToString(format);
            return dateHour;
        }

        public string getDateSevenDaysAgo()
        {
            DateTime timeCurrent = DateTime.Now;
            DateTime timeSevenDaysAgo = timeCurrent.AddDays(-7);
            string format = "yyyy-MM-dd ";
            string dateSeven = timeSevenDaysAgo.ToString(format);
            return dateSeven;
        }

        public string getDayOfWeekToday()
        {
            DateTime timeCurrent = DateTime.Now;
            string dayOfWeek = timeCurrent.ToString("dddd", new System.Globalization.CultureInfo("it-IT"));
            return dayOfWeek;
        }

        public string getDayOfWeekOneYearFromNow()
        {
            DateTime timeCurrent = DateTime.Now;
            DateTime timeOneYearFromNow = timeCurrent.AddYears(1);
            string dayOfWeekOneYear = timeOneYearFromNow.ToString("dddd", new System.Globalization.CultureInfo("it-IT"));
            return dayOfWeekOneYear;
        }
    }
}

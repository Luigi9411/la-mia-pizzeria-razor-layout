namespace la_mia_pizzeria_razor_layout.Models
{
    public class DateT
    {
        public string Format { get; set; }

        public string DateHour { get; set; }

        public string getDateHour()
        {
            DateTime timeCurrent = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string dateHour = timeCurrent.ToString(format);
            return dateHour;
        }
    }
}

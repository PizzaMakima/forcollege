using System;
using System.Windows.Forms;

namespace ProjectOne
{
    public class Calendar
    {
        public static void Main()
        {
            DateTime now = GetCurrentDate();
            MessageBox.Show($"Today's date is {now.ToShortDateString()}", "Current Date");
        }
        static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}

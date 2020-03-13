using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores
{
    class AppConstants
    {
        //Close Image
        private static string locationClose = @"C:\Users\Harry Jackson\source\repos\WindowsFormsApp1\WindowsFormsApp1\assets\close.png";
        private static Image imgClose = Image.FromFile(locationClose);
        public static Bitmap icClose = new Bitmap(imgClose, new Size(16, 16));

        //Close Active Image
        private static string locationCloseActive = @"C:\Users\Harry Jackson\source\repos\WindowsFormsApp1\WindowsFormsApp1\assets\closeActive.png";
        private static Image imgCloseActive = Image.FromFile(locationCloseActive);
        public static Bitmap icCloseActive = new Bitmap(imgCloseActive, new Size(16, 16));

        public class Colors
        {
            public static Color colorPrimary = ColorTranslator.FromHtml("#006BBB");
            public static Color colorPrimaryLight = ColorTranslator.FromHtml("#30A0E0");
            public static Color colorAccent = ColorTranslator.FromHtml("#FFC872");
            public static Color colorAccentLight = ColorTranslator.FromHtml("#FFE3B3");
        }

        public class DataPoints
        {
            public static string BASEURL = "https://ez-chores.firebaseio.com/";
            public static string USERS = "users";
            public static string JOB_POSTS = "jobPosts";
            public static string CHORES = "chores";
            public static string HISTORY = "history";
            public static string APPLIED_USERS = "appliedUsers";
            public static string JOB_STATUS = "jobStatus";
            public static string ACTIVE_JOBS = "activeJobs";
            public static string APPLIED_JOBS = "appliedJobs";
            public static string OFFERED_USER = "offeredUser";
            public static string API_KEY = "AIzaSyAkfEoUWvZOIQStJQmtAi7rF0Jj3TWbVdY";
            public static string ADMIN_EMAIL = "naingaunglu01@gmail.com";
            public static string ADMIN_PASSWORD = "luuluu09";
        }

        public class UserTypes
        {
            public static string WORKER = "WORKER";
            public static string EMPLOYER = "EMPLOYER";
        }

        public class ChoreTypes
        {
            public static string HOUSE_KEEPING = "HOUSE_KEEPING";
            public static string GARDENING = "GARDENING";
            public static string CARPENTING = "CARPENTING";
            public static string COOKING = " COOKING";
            public static string NURSING = "NURSING";
            
        }

        public class JobStatus
        {
            public static string APPLICABLE = "APPLICABLE";
            public static string APPLIED = "APPLIED";
            public static string IN_PROGRESS = "IN_PROGRESS";
            public static string DONE = "DONE";
        }

    }
}

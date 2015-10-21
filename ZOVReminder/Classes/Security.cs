using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZOVReminder.Classes
{
    public class Security
    {
        public int ZOVReminderUsersID { get; set; }
        public string UserName { get; set; }
        public  int Permissions { get; set; }
        public bool IsAdmin { get; set; }
    }
}

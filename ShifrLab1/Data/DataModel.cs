using System;
using System.Collections.Generic;
using System.Text;

namespace ShifrLab1.Data
{
    public class DataModel // class for each user
    {
        public string login { get; set; }
        public string password { get; set; }
        public bool isBlocked { get; set; }
        public bool passwordIsLimited { get; set; }
    }
}

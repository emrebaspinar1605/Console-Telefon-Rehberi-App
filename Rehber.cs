using System;
using System.Collections;

namespace telefonapp
{
    public class Rehber
    {
        
        private string name;
        private string surName;
        private string tel;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Tel { get => tel; set => tel = value; }

        public Rehber(string name,string surName, string tel)
        {
            Name=name;
            SurName=surName;
            Tel=tel;
        }
        public Rehber()
        {
            
        }
    }
}
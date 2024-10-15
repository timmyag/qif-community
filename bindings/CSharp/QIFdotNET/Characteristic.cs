using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIFdotNET
{
    public class Characteristic // a class to hold characteristic information
    {
        public string Part_Description { get; set; }
        public string Program_version { get; set; }
        public string Program_Standard { get; set; }
        public string Drawing_Number { get; set; }
        public string Drawing_Issue { get; set; }
        public string Drawing_Title { get; set; }
        public string Program_Type { get; set; }
        public string CMM_Number { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public string Programme_Run_Time { get; set; }
        public string name { get; set; }
        public string lable { get; set; }
        public Type type { get; set; }
        public decimal nominal_location_x { get; set; }
        public decimal nominal_location_y { get; set; }
        public decimal nominal_location_z { get; set; }
        public decimal actual_location_x { get; set; }
        public decimal actual_location_y { get; set; }
        public decimal actual_location_z { get; set; }
        public decimal nominal { get; set; }
        public decimal hitol { get; set; }
        public decimal lotol { get; set; }
        public decimal actual { get; set; }
        public string status { get; set; }


        public enum Type
        {
            CircleFeature
        }

        public Characteristic() { }
       
        public Characteristic(Characteristic inCharacteristic)
        {
            Part_Description = inCharacteristic.Part_Description;
            Program_version = inCharacteristic.Program_version;
            Program_Standard = inCharacteristic.Program_Standard;
            Drawing_Number = inCharacteristic.Drawing_Number;
            Drawing_Issue = inCharacteristic.Drawing_Issue;
            Drawing_Title = inCharacteristic.Drawing_Title;
            Program_Type = inCharacteristic.Program_Type;
            CMM_Number = inCharacteristic.CMM_Number;
            Comment = inCharacteristic.Comment;
            Date = inCharacteristic.Date;
            Programme_Run_Time = inCharacteristic.Programme_Run_Time;
    }

    }
}

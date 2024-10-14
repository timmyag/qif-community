using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIFdotNET
{
    public class Characteristic // a class to hold characteristic information
    {
        public string name;
        public string lable;
        public Type type;
        public string location;
        public string vector;
        public string tol;

        public enum Type
        {
            CircleFeature
        }
    }
}

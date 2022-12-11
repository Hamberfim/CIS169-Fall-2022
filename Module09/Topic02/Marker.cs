using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    public class Marker:WritingUtensil
    {
        
        // Constructors
        public Marker() : base()
        {

        }
        public Marker(string color, bool permanent): base(color, permanent)
        {

        }

        public new string write()
        {
            return "Marker writes in " + base.write();
        }

        public override string ToString()
        {
            return base.ToString(); 
        }

    }
}

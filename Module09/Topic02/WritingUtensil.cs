using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    public class WritingUtensil
    {
        private string _color;
        private bool _isPermanent;

        // Default no-arg constructor
        public WritingUtensil()
        {
            _color = "unknown";
            _isPermanent = true; 
        }
        public WritingUtensil(string color, bool isPermanent)
        {
            _color = color;
            _isPermanent = isPermanent;
        }
        
        public string Color { get => _color; set => _color = value; }
        public bool IsPermanent { get => _isPermanent; set => _isPermanent = value; }

        public virtual string write()
        {
            return "writes in " + _color; 
        }

        public override string ToString()
        {
            string permanent = "permanent";
            if (!_isPermanent)
            {
                permanent = "erasable";
            }
            return base.ToString() + ": color:" + _color + " " + permanent; 
        }
    }
}

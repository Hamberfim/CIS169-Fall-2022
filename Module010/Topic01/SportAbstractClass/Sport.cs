using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAbstractClass
{
    public abstract class Sport
    {
        private string _sportName;
        private string _sportEquipment;
        private int _numberOfPlayers;

        protected Sport()
        {
            SportName = "UNKNOWN";
            SportEquipment = "UNKNOWN";
            NumberOfPlayers = -1;
        }

        protected Sport(string sportName, string sportEquipment, int numberOfPlayers)
        {
            this.SportName = sportName;
            this.SportEquipment = sportEquipment;
            this.NumberOfPlayers = numberOfPlayers;
        }

        public string SportName { get => _sportName; set => _sportName = value; }
        public string SportEquipment { get => _sportEquipment; set => _sportEquipment = value; }
        public int NumberOfPlayers { get => _numberOfPlayers; set => _numberOfPlayers = value; }

        // in sub-class returns a string describing the game - (placement here means implementation will be required in sub-class ?)
        public abstract string Play();


        public override string ToString()
        {
            return $"{SportName} requires {NumberOfPlayers} people and {SportEquipment}";
        }
    }
}

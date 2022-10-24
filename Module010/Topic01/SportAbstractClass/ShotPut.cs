namespace SportAbstractClass
{
    internal class ShotPut : Sport
    {
        public ShotPut(string sportName, string sportEquipment, int numberOfPlayers) : base(sportName, sportEquipment, numberOfPlayers)
        {
            this.SportName = sportName;
            this.SportEquipment = sportEquipment;
            this.NumberOfPlayers = numberOfPlayers;
        }

        public override string Play()
        {
            return "The object of Shot Put is to 'put' the shot as far as possible away from position of the player.";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
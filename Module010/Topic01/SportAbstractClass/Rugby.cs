namespace SportAbstractClass
{
    public class Rugby : Sport
    {
        public Rugby(string sportName, string sportEquipment, int numberOfPlayers) : base(sportName, sportEquipment, numberOfPlayers)
        {
            this.SportName = sportName;
            this.SportEquipment = sportEquipment;
            this.NumberOfPlayers = numberOfPlayers;
        }


        public override string Play()
        {
            return "The object of Rugby is to ground the ball behind the opponent's try line, into what is called the in-goal area.";
        }

        public int FormTeam()
        {
            return NumberOfPlayers;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
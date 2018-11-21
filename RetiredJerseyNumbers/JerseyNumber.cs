namespace RetiredJerseyNumbers
{
    public class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int year)
        {
            Player = player;
            YearRetired = year;
        }

        public override string ToString()
        {
            return Player;
        }
    }
}
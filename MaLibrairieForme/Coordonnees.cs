namespace MaLibrairieForme
{
    public class Coordonnees
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Coordonnees(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordonnees() : this(0, 0)
        {

        }

        public override string ToString()
        {
            return "("+X+", "+Y+")";
        }
    }
}
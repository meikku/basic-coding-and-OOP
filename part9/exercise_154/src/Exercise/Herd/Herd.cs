namespace Exercise
{
    using System.Collections.Generic;
    public class Herd : IMovable
    {
        private List<IMovable> herd;

        public Herd()
        {
            this.herd = new List<IMovable>();
        }

        public void AddToHerd(IMovable movable)
        {
            this.herd.Add(movable);
        }

        public void Move(int dx, int dy)
        {
            foreach (IMovable member in herd)
            {
                member.Move(dx, dy);
            }

        }

        public override string ToString()
        {
            string herdCoordinates = "";

            foreach (IMovable member in herd)
            { 
              herdCoordinates = herdCoordinates + member.ToString() + "\n";

            }
            return herdCoordinates;
        }
    }
}
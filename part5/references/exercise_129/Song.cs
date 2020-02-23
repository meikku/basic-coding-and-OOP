namespace exercise_129
{

    public class Song
    {

        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }

        // BEGIN SOLUTION
        public override bool Equals(object compared)
        {
        
            if (this.artist.Equals(compared) && (this.name.Equals(compared)) && this.durationInSeconds.Equals(compared))
            {
                return true;
            }
            return false;
        }

        // END SOLUTION

    }

}
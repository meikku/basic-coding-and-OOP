namespace Exercise
{
    public class LicensePlate
    {
        public string liNumber { get; }
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }

        public override string ToString()
        {
            return country + " " + liNumber;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type Book, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            else
            {
                LicensePlate comparedLicensePlate = (LicensePlate)compared;
                return this.liNumber == comparedLicensePlate.liNumber && this.country == comparedLicensePlate.country;

                // convert the object to a Book object

                // if the values of the object variables are equal, the objects are, too

            }

        }

        public override int GetHashCode()
        {
            return this.liNumber.GetHashCode();
        }
    }
}
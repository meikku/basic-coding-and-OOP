using System.Collections.Generic;


namespace Exercise
{
    public class Abbreviations // tämä on luokan nimi
    {

        private Dictionary<string, string> abbreviations; // muuttujana kirjasto
        public Abbreviations() // constructor
        {
            this.abbreviations = new Dictionary<string, string>(); // luodaan uusi kirjasto

        }
        public void AddAbbreviation(string abbreviation, string explanation)
        {
            
            this.abbreviations.Add(abbreviation, explanation);
          

            
        }

        public bool HasAbbreviation(string abbreviation)
        {
            if (this.abbreviations.ContainsKey(abbreviation))
            {
                return true;
            }
            return false;
        }

        public string FindExplanationFor(string abbreviation)
        {
           

           if (HasAbbreviation(abbreviation))
           {  
               return abbreviations[abbreviation];
           }
            else {
                return "not found";
            }
            
        }
    }
}
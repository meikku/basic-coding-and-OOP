namespace Exercise
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    public class SaveableDictionary
    {
        private Dictionary<string, string> dictionary;
        private string file;
        public SaveableDictionary()
        {
            this.dictionary = new Dictionary<string, string>();
        }

        public SaveableDictionary(string file) : this()
        {
            this.file = file;
        }

        public void Add(string word, string translation)
        {
            if (!this.dictionary.ContainsKey(word))
                this.dictionary.Add(word, translation);
            this.dictionary.Add(translation, word);

        }

        public bool Load()
        {
            try
            {
                string[] lines = File.ReadAllLines(this.file);


                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    string word = parts[0];
                    string translation = parts[1];
                    Add(word, translation);

                }
            }
            catch
            {
                return false;
            }
            return true;

        }

        public bool Save()
        {
          

            try
            {
                StreamWriter sw = new StreamWriter(this.file);
                foreach (KeyValuePair<string, string> kvp in this.dictionary)
                {
                    // if (!this.dictionary.ContainsKey(kvp.Value))
                    // {
                    sw.WriteLine(kvp.Key + ":" + kvp.Value);

                    //}
                }
                sw.Close();
                return true;

            }
            catch 
            {
                return false;
            }
        }

        public string Translate(string word)
        {
            if (!dictionary.ContainsKey(word))
            {
                return null;
            }
            return dictionary[word];
        }

        public void Delete(string word)
        {
            string translation = this.dictionary[word];
            if (this.dictionary.ContainsKey(word))
            {
                this.dictionary.Remove(word);
                this.dictionary.Remove(translation);
            }
        }
    }
}
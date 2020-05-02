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
          
            List<string> savedWords = new List<string>();
            try
            {
                StreamWriter sw = new StreamWriter(this.file);
                foreach (string word in this.dictionary.Keys)
                
                {
                    // string translation = word + ":" + this.dictionary[word];
                    // string backwards = this.dictionary[word] + ":" + word;
                    // if (!savedWords.Contains(translation) && !savedWords.Contains(backwards))
                    // savedWords.Add(translation);
                    // sw.WriteLine(translation);

                    if (!savedWords.Contains(word) && !savedWords.Contains(this.dictionary[word]))
                    {
                        savedWords.Add(word);
                        sw.WriteLine(word + ":" + this.dictionary[word]);
                    }

                    
                }
                
                sw.Close();
                

            }
            catch 
            {
                return false;
            }
            return true;
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
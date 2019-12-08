using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    public class Hashtag
    {
        String _Text;

        public Hashtag(string text)
        {
            String[] words = text.Trim().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
            _Text = String.Join("", words);
        }

        public override string ToString()
        {
            return ToString("#");
        }

        public string ToString(String hash)
        {
            return hash + _Text;
        }
    }
}

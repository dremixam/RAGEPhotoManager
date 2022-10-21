using System;
using System.Collections.Generic;

namespace RAGEPhotoManager.Model
{
    public class Hashtag : IEquatable<Hashtag>
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

        public override bool Equals(object obj)
        {
            return obj is Hashtag hashtag &&
                   _Text == hashtag._Text;
        }

        public bool Equals(Hashtag other)
        {
            return other != null &&
                   _Text == other._Text;
        }

        public override int GetHashCode()
        {
            return -816887083 + EqualityComparer<string>.Default.GetHashCode(_Text);
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

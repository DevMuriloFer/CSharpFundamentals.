using System;
using System.Collections.Generic;
using System.Text;

namespace _09_StringBuilder.Entities
{
    internal class Comment
    {
        public string Text { get; set; }
        
        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}

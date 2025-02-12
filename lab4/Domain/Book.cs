using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4.Domain
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
        public virtual void CheckValidity()
        {
            if (string.IsNullOrWhiteSpace(Title))
                throw new ArgumentNullException("Title");
        }
    }
}


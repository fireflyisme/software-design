using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4.Domain
{
    public class TextBook: Book
    {
        public string? Subject { get; set; }
        public override string GetInfo()
        {
            return $"{Title}\t\tby {Author}\t   Subject: {Subject}\n";
        }
        public virtual void CheckValidity()
        {
            if (string.IsNullOrWhiteSpace(Subject))
                throw new ArgumentNullException("Subject");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Domain
{
    public class Audiobook: Book
    {
        public string? Narrator { get; set; }
        public int Duration { get; set; }
        public override string GetInfo()
        {
            return $"{Title}, narrated by {Narrator} - Duration: {Duration} minutes";
        }
    }
}

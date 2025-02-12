using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Domain
{
    public class Ebook:Book
    {
        public int FileSizeMB { get; set; }
        public override string GetInfo()
        {
            return $"{Title} (Ebook, {FileSizeMB}MB)";
        }
    }
}

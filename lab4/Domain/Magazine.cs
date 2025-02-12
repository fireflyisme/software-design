using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Domain
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }
        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }
        public override void CheckValidity()
        {
            if (IssueNumber < 0)
                throw new ArgumentNullException("IssueNumber");
        }
    }
}

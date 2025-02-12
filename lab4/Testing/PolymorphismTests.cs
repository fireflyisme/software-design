using lab4.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Testing
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
            new Book { Title = "Generic Book", Author = "John Smith"},
            new Magazine { Title = "Tech Weekly", IssueNumber = 12},
            new Ebook { Title = "Learn C#", FileSizeMB = 5}
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
        }
    }
}

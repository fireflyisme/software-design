
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4.Domain;

namespace lab4.Testing
{
    [TestClass]
    public sealed class Book_Class_Test
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book()
            {
                Title = "C# Programming",
                Author = "John Smith"
            };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
        [TestMethod]
        public void TestMagaizineCreation()
        {
            var magazine = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 12
            };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }
    }
}

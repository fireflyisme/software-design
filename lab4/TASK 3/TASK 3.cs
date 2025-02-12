using lab4.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.TASK_3
{
    [TestClass]
    public class TASK_3
    {
            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void CreatingBook_WithEmptyTitle_ShouldThrowException()
            {
                Book book = new Ebook() { Title = "", Author = "" };
                book.CheckValidity();
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void CreatingMagazine_WithNegativeIssueNumber_ShouldThrowException()
            {
                Book magazine = new Magazine() { Title = "Tech Weekly", IssueNumber = -1 };
                magazine.CheckValidity();
        }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void CreatingTextBook_WithEmptySubject_ShouldThrowException()
            {
                var textbook = new TextBook() { Title = "OOP Basics", Author = "Jay Al", Subject = "" };
                textbook.CheckValidity();
        }
        }
    }

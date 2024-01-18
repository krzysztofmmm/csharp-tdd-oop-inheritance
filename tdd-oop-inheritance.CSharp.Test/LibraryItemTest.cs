﻿using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryItemTest
    {
        [Test]
        public void ShouldCheckInAndOutBook()
        {
            Book book = new Book("A Great Book");

            Assert.AreEqual("item has been checked out" , book.CheckOut());
            Assert.AreEqual("item has been checked in" , book.CheckIn());
        }

        [Test]
        public void ShouldCheckInAndOutArticle()
        {
            Article article = new Article("An Interesting Article");

            Assert.AreEqual("item has been checked out" , article.CheckOut());
            Assert.AreEqual("item has been checked in" , article.CheckIn());
        }

        [Test]
        public void ShouldNotLoanNewspaper()
        {
            Newspaper newspaper = new Newspaper("Today's News");

            Assert.AreEqual("newspapers are not available for loan" , newspaper.CheckOut());
            Assert.AreEqual("newspapers are not available for loan" , newspaper.CheckIn());
        }
    }

}
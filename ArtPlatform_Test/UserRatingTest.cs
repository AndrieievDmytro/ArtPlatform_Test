using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class UserRatingTest
    {
        int id = 1;
        decimal value = 4;
        string desc = "dqwdqw";
        Post Post;
        User User;
        UserRating Rating;

        [SetUp]
        public void Setup()
        {
            Rating = new UserRating(id, value, desc, Post, User);
        }

        [Test]
        public void IdRatingTest()
        {
            Assert.AreEqual(id, Rating.IdRating);
        }

        [Test]
        public void RatingValueTest()
        {
            Assert.AreEqual(value, Rating.RatingValue);
            value = -10;
            Exception ex = Assert.Throws<ArgumentException>(() => { Rating.RatingValue = value; });
        }

        [Test]
        public void DescriptionTest()
        {
            Assert.AreEqual(desc, Rating.Description);
            desc = "ddd";
            Rating.Description = desc;
            Assert.AreEqual(desc, Rating.Description);
        }

    }
}
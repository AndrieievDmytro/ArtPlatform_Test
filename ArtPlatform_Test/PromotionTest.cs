using NUnit.Framework;
using ArtPlatform.Models;
using System;

namespace ArtPlatform_Test
{
    public class PromotionTest
    {
        private Promotion _promotion;
        private Artist _artist;

        [SetUp]
        public void Setup()
        {
            _artist = new Artist();
            _promotion = new Promotion(1, "bonus", new DateTime(2021, 12, 16), new DateTime(2021, 12, 17), _artist);
        }
        //Getters
        [Test]
        public void GetPromotionId()
        {
            Assert.AreEqual(_promotion.IdPromotion, 1);
        }
        [Test]
        public void GetPromotionType()
        {
            Assert.AreEqual(_promotion.PromotionType, "bonus");
        }
        [Test]
        public void GetStartDate()
        {
            Assert.AreEqual(_promotion.StartDate, new DateTime(2021, 12, 16));

        }
        [Test]
        public void GetEndDate()
        {
            Assert.AreEqual(_promotion.EndDate, new DateTime(2021, 12, 17));
        }
        [Test]
        public void GetArtist()
        {
            Assert.AreEqual(_promotion.Artist, _artist); 
        }
        
        //Setters

        [Test]
        public void SetPromotionId()
        {
            _promotion.IdPromotion = 2;
            Assert.AreEqual(_promotion.IdPromotion, 2 );
        }
        [Test]
        public void SetPromotionType()
        {
            _promotion.PromotionType = "bonus_modified";
            Assert.AreEqual(_promotion.PromotionType, "bonus_modified");
        }
        [Test]
        public void SetStartDate()
        {
            _promotion.StartDate = new DateTime(2021, 12, 15);
            Assert.AreEqual(_promotion.StartDate, new DateTime(2021, 12, 15));

        }
        [Test]
        public void SetEndDate()
        {
            _promotion.EndDate = new DateTime(2021, 12, 16);
            Assert.AreEqual(_promotion.EndDate, new DateTime(2021, 12, 16));
        }
        [Test]
        public void SetArtist()
        {
            Artist newArtist = new Artist();
            _promotion.Artist = newArtist;
            Assert.AreEqual(_promotion.Artist, newArtist); 
        }
    }
}
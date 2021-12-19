using NUnit.Framework;
using ArtPlatform.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtPlatform_Test
{
    public class PurchaseTest
    {

        private Purchase _purchase;
        private ArtWork _artWork;
        private List<ArtWork> _purchasedArtworks;
        private User _user;


        [SetUp]
        public void Setup()
        {

            string videoLink = "videoLink";
            string photoLink = "photoLink";
            List<Post> _post = new List<Post>();
            _post.Add(new Post(1,""));
            Artist _artist = new Artist();
            List<string> _videoList = new List<string>();
            List<string> _photoList = new List<string>();
            _purchasedArtworks = new List<ArtWork>();
            _artWork = new ArtWork(1, _artist, "artType", "description", _videoList, _photoList, _post);

            _videoList.Add(videoLink);
            _photoList.Add(photoLink);
            _purchasedArtworks.Add(_artWork);

            _user = new User();
            _purchase = new Purchase(1, 100, "bought", _purchasedArtworks, _user);
        }

        //Getters
        [Test]
        public void GetPurchaseId()
        {
            Assert.AreEqual(1, _purchase.IdPurchase);
        }
        [Test]
        public void GetPurchasePrice()
        {
            Assert.AreEqual((decimal)100, _purchase.Price);
        }
        [Test]
        public void GetPurchseState()
        {
            Assert.AreEqual("bought", _purchase.State);
        }
        [Test]
        public void GetPurchasedArtWorks()
        {
            Assert.AreEqual(_artWork, _purchase.PurchasedArtworks.First());
        }
        [Test]
        public void GetBuyer()
        {
            Assert.AreEqual(_user, _purchase.Buyer);
        }

        //Setters
        [Test]
        public void SetPurchaseId()
        {
            _purchase.IdPurchase = 2;
            Assert.AreEqual(2, _purchase.IdPurchase);
        }
        [Test]
        public void SetPurchasePrice()
        {
            _purchase.Price = 200;
            Assert.AreEqual((decimal)200, _purchase.Price);
        }
        [Test]
        public void SetPurchseState()
        {
            _purchase.State = "sent";
            Assert.AreEqual("sent", _purchase.State);
        }
        [Test]
        public void SetPurchasedArtWorks()
        {
            List<Post> _post = new List<Post>();
            _post.Add(new Post(1,""));
            Artist _artist = new Artist();
            List<string> _videoList = new List<string>();
            List<string> _photoList = new List<string>();
            _purchasedArtworks = new List<ArtWork>();
            var newArtWork = new ArtWork(1, _artist, "artType", "description", _videoList, _photoList, _post);
            var newPurchasedArtworks = new List<ArtWork>();
            newPurchasedArtworks.Add(newArtWork);
            _purchase.PurchasedArtworks = newPurchasedArtworks;

            Assert.AreEqual(newArtWork, _purchase.PurchasedArtworks.First());
            Assert.NotNull(_purchase);
            Assert.LessOrEqual(1, newPurchasedArtworks.Count);
        }
        [Test]
        public void SetBuyer()
        {
            var newUser = new User();
            _purchase.Buyer = newUser;
            Assert.AreEqual(newUser, _purchase.Buyer);
        }


    }
}
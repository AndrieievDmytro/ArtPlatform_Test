using NUnit.Framework;
using ArtPlatform.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtPlatform_Test
{
    public class ArtWorkTest
    {
        private ArtWork _artWork;
        private List<string> _videoList;
        private List<string> _photoList;
        private List<Post> _post;
        private Artist _artist;

        [SetUp]
        public void Setup()
        {

            _post = new List<Post>();
            Post post = new Post(1,""); 
            string videoLink = "videoLink";
            string photoLink = "photoLink";
            _post.Add(post);
            _artist = new Artist();
            _videoList = new List<string>();
            _photoList = new List<string>();

            _videoList.Add(videoLink);
            _photoList.Add(photoLink);

            _artWork = new ArtWork(1, _artist, "artType", "description", _videoList, _photoList, _post);
        }

        //Getters

        [Test]
        public void GetArtWorkId()
        {
            Assert.AreEqual(1, _artWork.IdArtwork);
        }
        [Test]
        public void GetArtist()
        {
            Assert.AreEqual(_artWork.Artist, _artist);
        }
        [Test]
        public void GetArtType()
        {
            Assert.AreEqual(_artWork.ArtType, "artType");
        }
        [Test]
        public void GetArtDescription()
        {
            Assert.AreEqual(_artWork.Description, "description");
        }
        [Test]
        public void GetVideoList()
        {
            Assert.AreEqual(_artWork.Video.First(), "videoLink");
            Assert.IsNotNull(_artWork.Video);
            Assert.LessOrEqual(1, _artWork.Video.Count);
        }

        [Test]
        public void GetPhotoList()
        {
            Assert.AreEqual(_artWork.Photo.First(), "photoLink");
            Assert.IsNotNull(_artWork.Photo);
            Assert.LessOrEqual(1, _artWork.Photo.Count);
        }

        [Test]
        public void GetPost()
        {
            Assert.AreEqual(_artWork.Post, _post);
        }
    
    //Setters

        [Test]
        public void SetArtWorkId()
        {
            _artWork.IdArtwork = 2;
            Assert.AreEqual(2, _artWork.IdArtwork);
        }
        [Test]
        public void SetArtist()
        {
            var newArtist = new Artist();
            _artWork.Artist = newArtist;
            Assert.AreEqual(_artWork.Artist, newArtist);
        }
        [Test]
        public void SetArtType()
        {
            _artWork.ArtType = "newArtType";
            Assert.AreEqual(_artWork.ArtType, "newArtType");
        }
        [Test]
        public void SetArtDescription()
        {
            _artWork.Description = "newDescription";
            Assert.AreEqual(_artWork.Description, "newDescription");
        }
        [Test]
        public void SetVideoList()
        {
            var newVideoList = new List<string>();
            newVideoList.Add("newVideo");
            _artWork.Video = newVideoList;

            Assert.AreEqual(_artWork.Video.First(), "newVideo");
            Assert.IsNotNull(_artWork.Video);
            Assert.LessOrEqual(1, _artWork.Video.Count);
        }

        [Test]
        public void SetPhotoList()
        {
            var newPhotoList = new List<string>();
            newPhotoList.Add("newPhoto");
            _artWork.Photo = newPhotoList;

            Assert.AreEqual(_artWork.Photo.First(), "newPhoto");
            Assert.IsNotNull(_artWork.Photo);
            Assert.LessOrEqual(1, _artWork.Photo.Count);
        }

        [Test]
        public void SetPost()
        {
            Post newPost = new Post(1,"");
            _post.Add(newPost);
            _artWork.Post[1] = newPost; 
            Assert.AreEqual(_artWork.Post[1], newPost);
        }



    }
}
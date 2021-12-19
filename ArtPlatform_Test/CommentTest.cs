using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class CommentTest
    {
        Comment Comment;
        User User;
        Post Post;
        int Id;
        DateTime Date;
        string Text;

        [SetUp]
        public void Setup()
        {
            Id = 1;
            Text = "some text";
            Date = DateTime.Now;
            User = new User();
            Post = new Post(Id, Text);
            Comment = new Comment(Id, Text, Date, null, User, Post);

        }

        [Test]
        public void IdCommentTest()
        {
            Assert.AreEqual(1, Comment.IdComment);
            Comment.IdComment = 2;
            Assert.AreEqual(2, Comment.IdComment);
        }

        [Test]
        public void CommentTextTest()
        {
            Assert.AreEqual("some text", Comment.CommentText);
            Text = "some comment2";
            Comment.CommentText = Text;
            Assert.AreEqual(Text, Comment.CommentText);
        }

        [Test]
        public void CreationDateTest()
        {
            Assert.AreEqual(Date, Comment.CreationDate);
            Date = DateTime.Now.AddDays(120);
            Comment.CreationDate = Date;
            Assert.AreNotEqual(Date, Comment.CreationDate);
        }


        [Test]
        public void EditDateTest()
        {
            Date = DateTime.Now.AddDays(1);
            Comment.EditDate = Date;
            Assert.AreEqual(Date, Comment.EditDate);

            Date = DateTime.Now.AddDays(-30);
            Comment.EditDate = Date;
            Assert.AreNotEqual(Date, Comment.EditDate);
        }

        



    }
}
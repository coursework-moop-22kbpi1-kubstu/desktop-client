using System;

namespace WindowsFormsApp.Model.Entities
{
    public class Notification : IEntity
    {
        int id;
        string title;
        string message;
        DateTime createdAt;
        User userOwner;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public User Owner
        {
            get { return userOwner; }
            set { userOwner = value; }
        }
        public Notification(int id, string title, string message, DateTime createdAt, User userOwner)
        {
            this.id = id;
            this.title = title;
            this.message = message;
            this.createdAt = createdAt;
            this.userOwner = userOwner;
        }
    }
}
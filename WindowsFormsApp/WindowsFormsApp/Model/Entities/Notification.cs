using System;

namespace WindowsFormsApp.Model.Entities
{
    public class Notification
    {
        int id;
        string title;
        string message;
        DateTime createdAt;
        User userOwner;
    }
}
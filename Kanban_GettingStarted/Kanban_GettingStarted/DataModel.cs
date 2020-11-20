using Syncfusion.SfKanban.iOS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kanban_GettingStarted
{
    public class DataModel
    {
        public ObservableCollection<KanbanModel> Cards { get; set; }

        public List<object> IList;

        public DataModel()
        {
            Cards = new ObservableCollection<KanbanModel>();

            IList = new List<object>() { "Open", "Test", "Close", "InProgress" };

            Cards.Add(
                new KanbanModel()
                {
                    ID = 1,
                    Title = "iOS - 1",
                    ImageURL = "Image1.png",
                    Category = "Open",
                    Description = "Analyze customer requirements",
                    ColorKey = "Red",
                    Tags = new string[] { "Bug", "Customer", "Release Bug" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 6,
                    Title = "Xamarin - 6",
                    ImageURL = "Image2.png",
                    Category = "Open",
                    Description = "Show the retrived data from the server in grid control",
                    ColorKey = "Red",
                    Tags = new string[] { "Bug", "Customer", "Breaking Issue" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 3,
                    Title = "iOS - 3",
                    ImageURL = "Image3.png",
                    Category = "Open",
                    Description = "Fix the filtering issues reported in safari",
                    ColorKey = "Red",
                    Tags = new string[] { "Bug", "Customer", "Breaking Issue" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 11,
                    Title = "iOS - 11",
                    ImageURL = "Image4.png",
                    Category = "Open",
                    Description = "Add input validation for editing",
                    ColorKey = "Red",
                    Tags = new string[] { "Bug", "Customer", "Breaking Issue" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 15,
                    Title = "Android - 15",
                    Category = "Open",
                    ImageURL = "Image5.png",
                    Description = "Arrange web meeting for cutomer requirement",
                    ColorKey = "Red",
                    Tags = new string[] { "Story", "Kanban" }
                });

            Cards.Add(
                new KanbanModel()
                {
                    ID = 3,
                    Title = "Android - 3",
                    Category = "Code Review",
                    ImageURL = "Image6.png",
                    Description = "API Improvements",
                    ColorKey = "Purple",
                    Tags = new string[] { "Bug", "Customer" }
                });

            Cards.Add(
                new KanbanModel()
                {
                    ID = 4,
                    Title = "UWP - 4",
                    ImageURL = "Image7.png",
                    Category = "Code Review",
                    Description = "Enhance editing functionality",
                    ColorKey = "Brown",
                    Tags = new string[] { "Story", "Kanban" }
                });

            Cards.Add(
                new KanbanModel()
                {
                    ID = 9,
                    Title = "Xamarin - 9",
                    ImageURL = "Image8.png",
                    Category = "Code Review",
                    Description = "Improve application performance",
                    ColorKey = "Orange",
                    Tags = new string[] { "Story", "Kanban" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 13,
                    Title = "UWP - 13",
                    ImageURL = "Image9.png",
                    Category = "In Progress",
                    Description = "Add responsive support to applicaton",
                    ColorKey = "Brown",
                    Tags = new string[] { "Story", "Kanban" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 17,
                    Title = "Xamarin - 17",
                    Category = "In Progress",
                    ImageURL = "Image10.png",
                    Description = "Fix the issues reported in IE browser",
                    ColorKey = "Brown",
                    Tags = new string[] { "Bug", "Customer" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 21,
                    Title = "Xamarin - 21",
                    Category = "In Progress",
                    ImageURL = "Image11.png",
                    Description = "Improve performance of editing functionality",
                    ColorKey = "Purple",
                    Tags = new string[] { "Bug", "Customer" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 19,
                    Title = "iOS - 19",
                    Category = "In Progress",
                    ImageURL = "Image12.png",
                    Description = "Fix the issues reported by the customer",
                    ColorKey = "Purple",
                    Tags = new string[] { "Bug" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 8,
                    Title = "Android",
                    Category = "Code Review",
                    ImageURL = "Image13.png",
                    Description = "Check login page validation",
                    ColorKey = "Brown",
                    Tags = new string[] { "Feature" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 24,
                    Title = "UWP - 24",
                    ImageURL = "Image14.png",
                    Category = "In Progress",
                    Description = "Test editing functionality",
                    ColorKey = "Orange",
                    Tags = new string[] { "Feature", "Customer", "Release" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 20,
                    Title = "iOS - 20",
                    Category = "In Progress",
                    ImageURL = "Image15.png",
                    Description = "Fix the issues reported in data binding",
                    ColorKey = "Red",
                    Tags = new string[] { "Feature", "Release", }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 12,
                    Title = "Xamarin - 12",
                    Category = "In Progress",
                    ImageURL = "Image16.png",
                    Description = "Test editing functionality",
                    ColorKey = "Red",
                    Tags = new string[] { "Feature", "Release", }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 11,
                    Title = "iOS - 11",
                    Category = "In Progress",
                    ImageURL = "Image17.png",
                    Description = "Check filtering validation",
                    ColorKey = "Red",
                    Tags = new string[] { "Feature", "Release", }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 13,
                    Title = "UWP - 13",
                    ImageURL = "Image18.png",
                    Category = "Closed",
                    Description = "Fix cannot open user's default database sql error",
                    ColorKey = "Purple",
                    Tags = new string[] { "Bug", "Internal", "Release" }
                });

            Cards.Add(
                new KanbanModel()
                {
                    ID = 14,
                    Title = "Android - 14",
                    Category = "Closed",
                    ImageURL = "Image19.png",
                    Description = "Arrange web meeting with customer to get login page requirement",
                    ColorKey = "Red",
                    Tags = new string[] { "Feature" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 15,
                    Title = "Xamarin - 15",
                    Category = "Closed",
                    ImageURL = "Image20.png",
                    Description = "Login page validation",
                    ColorKey = "Red",
                    Tags = new string[] { "Bug" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 16,
                    Title = "Xamarin - 16",
                    ImageURL = "Image21.png",
                    Category = "Closed",
                    Description = "Test the application in IE browser",
                    ColorKey = "Purple",
                    Tags = new string[] { "Bug" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 20,
                    Title = "UWP - 20",
                    ImageURL = "Image22.png",
                    Category = "Closed",
                    Description = "Analyze stored procedure",
                    ColorKey = "Brown",
                    Tags = new string[] { "CustomSample", "Customer", "Incident" }
                }
            );

            Cards.Add(
                new KanbanModel()
                {
                    ID = 21,
                    Title = "Android - 21",
                    Category = "Closed",
                    ImageURL = "Image23.png",
                    Description = "Arrange web meeting with customer to get editing requirements",
                    ColorKey = "Orange",
                    Tags = new string[] { "Story", "Improvement" }
                }
            );

        }
    }
}
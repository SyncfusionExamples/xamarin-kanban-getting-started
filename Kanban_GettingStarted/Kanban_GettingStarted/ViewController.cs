using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using Syncfusion.SfKanban.iOS;
using UIKit;

namespace Chart_GettingStarted
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        DataModel model = new DataModel();
        SfKanban kanban;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            kanban = new SfKanban();
            kanban.ItemsSource = model.Cards;

            KanbanColumn column1 = new KanbanColumn();
            column1.Title = "To Do";
            column1.MinimumLimit = 5;
            column1.MaximumLimit = 15;
            column1.Categories = new List<object> { "Open", "Postponed", "Validated" };
            kanban.Columns.Add(column1);

            KanbanColumn column2 = new KanbanColumn();
            column2.Title = "In Progress";
            column2.MinimumLimit = 3;
            column2.MaximumLimit = 8;
            column2.Categories = new List<object> { "In Progress" };
            kanban.Columns.Add(column2);

            KanbanColumn column3 = new KanbanColumn();
            column3.Title = "Code Review";
            column3.MinimumLimit = 5;
            column3.MaximumLimit = 10;
            column3.Categories = new List<object> { "Code Review" };
            kanban.Columns.Add(column3);

            KanbanColumn column4 = new KanbanColumn();
            column4.Title = "Done";
            column4.MinimumLimit = 8;
            column4.MaximumLimit = 12;
            column4.Categories = new List<object> { "Closed", "Closed-No Code Changes", "Resolved" };
            kanban.Columns.Add(column4);

            List<KanbanColorMapping> colormodels = new List<KanbanColorMapping>();
            colormodels.Add(new KanbanColorMapping("Purple", UIColor.Purple));
            colormodels.Add(new KanbanColorMapping("Red", UIColor.Red));
            colormodels.Add(new KanbanColorMapping("Orange", UIColor.Brown));
            colormodels.Add(new KanbanColorMapping("Brown", UIColor.Green));
            kanban.IndicatorColorPalette = colormodels;

            List<KanbanWorkflow> keyfield = new List<KanbanWorkflow>();
            keyfield.Add(new KanbanWorkflow("Open", new List<object> { "In Progress" }));
            keyfield.Add(new KanbanWorkflow("In Progress", new List<object> { "Postponed", "Validated", "Code Review", "Closed-No Code Changes" }));
            keyfield.Add(new KanbanWorkflow("Code Review", new List<object> { "Closed", "Resolved" }));
            keyfield.Add(new KanbanWorkflow("Closed", new List<object> { "Open" }));
            keyfield.Add(new KanbanWorkflow("Postponed", new List<object> { "In Progress" }));
            keyfield.Add(new KanbanWorkflow("Validated", new List<object> { "In Progress" }));
            keyfield.Add(new KanbanWorkflow("Closed-No Code Changes", new List<object> { }));
            keyfield.Add(new KanbanWorkflow("Resolved", new List<object> { }));

            kanban.Workflows = keyfield;
            kanban.Frame = View.Frame;

            this.View.AddSubviews(kanban);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            kanban.Frame = View.Frame;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
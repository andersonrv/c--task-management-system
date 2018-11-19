using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Task_Management_System
{   
    partial class TUser
    {
    }

    partial class TBoard : TabPage
    {

        public TBoard(string Name, int UserId)
        {
            this.BoardName = Name;
            this.UserId = UserId;
            Text = Name;
            Controls.Add(new BoardContent());
        }

        public TBoard(int BoardId, string Name, int UserId)
        {
            
            this.BoardId = BoardId;
            this.BoardName = Name;
            this.UserId = UserId;
            
            Text = Name;
            Controls.Add(new BoardContent(this.BoardId));
        }
    }

    partial class TBoardAccess
    {
    }

    public partial class TList : UserControl
    {
        //LinkLabel taskLabel;
        string taskName;
        string taskMarker = "\u21DB ";
        Font taskFont = new Font("Arial", 9);
        Color taskLinkColor = Color.Black;
        Color taskActiveLinkColor = Color.Green;
        Size taskLabelSize = new Size(155, 0);
        bool taskAutoSize = true;
        

        Random rgb = new Random();
        int minValue = 100;
        int maxValue = 200;

        List<Task> ListOfTask = new List<Task>();

        public TList(int ListId, string ListName, int BoardId)
        {
            InitializeComponent();
            taskPanel.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
            ListNameLabel.Text = ListName;
            this.ListId = ListId;
        }

        public TList(string ListName, int BoardId)
        {
            InitializeComponent();
            taskPanel.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
            ListNameLabel.Text = ListName;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            taskName = taskInputBox.Text;
            LinkLabel taskLabel = new LinkLabel();
            taskLabel.Text = taskMarker + taskName + "\n";
            taskLabel.Font = taskFont;
            taskLabel.MaximumSize = taskLabelSize;
            taskLabel.AutoSize = taskAutoSize;
            taskLabel.LinkColor = taskLinkColor;
            taskLabel.ActiveLinkColor = taskActiveLinkColor;
            taskLabel.Click += Task_Click;
            if (taskName != "")
            {

                Task task = new Task(taskName);
                taskPanel.Controls.Add(taskLabel);
                ListOfTask.Add(task);
                taskInputBox.Text = "";

            }
            else
            {
                MessageBox.Show("Please enter a title for the task.");
            }

        }

        private void Task_Click(object sender, EventArgs e)
        {
            Task task = new Task(taskName);
            task.ShowDialog();
        }

        private void DeleteListButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete list "+ ListNameLabel.Text +"? \rThis action is not reversible.", "DELETE BOARD!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Remove from DB
                string propName = "ListId";
                int listIdToBeDeleted = (int)this.GetType().GetProperty(propName).GetValue(this, null);
                LinqToSQLCRUD.DeleteList(listIdToBeDeleted);
                
                // Destroy component in the ListArea
                this.Dispose();
            }
        }

    }

    partial class TTask
    {
    }

    partial class TStatus
    {
    }
}
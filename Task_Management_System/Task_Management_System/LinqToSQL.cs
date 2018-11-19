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
        Font taskFont = new Font("Arial", 8);
        Color taskLinkColor = Color.Black;
        Color taskActiveLinkColor = Color.Green;
        Random rgb = new Random();
        int minValue = 100;
        int maxValue = 200;
        

        List<TTask> ListOfTask = new List<TTask>();

        public TList(int listId, string listName, int boardId)
        {
            InitializeComponent();
            
            taskPanel.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
            ListNameLabel.Text = listName;
            this.ListId = listId;

            var tasks = LinqToSQLCRUD.ReadTasks(listId);
            foreach (var task in tasks)
            {
                LinkLabel taskLink = new LinkLabel();
                taskLink.Text = taskMarker + task.TaskName + "\n"; //task.TaskName;
                taskLink.Tag = task.TasktId;
                taskLink.Font = taskFont;
                taskLink.LinkColor = taskLinkColor;
                taskLink.ActiveLinkColor = taskActiveLinkColor;
                taskLink.Click += Task_Click;

                taskPanel.Controls.Add(taskLink);
            }
        }

        public TList(string listName, int boardId)
        {
            InitializeComponent();
            taskPanel.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
            ListNameLabel.Text = listName;

            var tasks = LinqToSQLCRUD.ReadTasks(ListId);
            foreach (var task in tasks)
            {
                LinkLabel taskLink = new LinkLabel();
                taskLink.Text = taskMarker + task.TaskName + "\n"; //task.TaskName;
                taskLink.Tag = task.TasktId;
                taskLink.Font = taskFont;
                taskLink.LinkColor = taskLinkColor;
                taskLink.ActiveLinkColor = taskActiveLinkColor;
                taskLink.Click += Task_Click;

                taskPanel.Controls.Add(taskLink);
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            taskName = taskInputBox.Text;

            if (taskName != "")
            {
                //Add Task to DB
                LinqToSQLCRUD.CreateTask(taskName, this.ListId);

                var lastTask = LinqToSQLCRUD.GetLastTaskInserted();

                foreach (var result in lastTask)
                {
                    LinkLabel taskLink = new LinkLabel();
                    taskLink.Text = taskMarker + result.TaskName + "\n"; //task.TaskName;
                    taskLink.Tag = result.TasktId;
                    taskLink.Font = taskFont;
                    taskLink.LinkColor = taskLinkColor;
                    taskLink.ActiveLinkColor = taskActiveLinkColor;
                    //taskLink.Click += Task_Click;
                    //taskLink.Click += Task_Click;
                    taskPanel.Controls.Add(taskLink);
                    Debug.WriteLine(taskLink.Tag);
                }
                
                taskInputBox.Text = "";

            }
            else
            {
                MessageBox.Show("Please enter a title for the task.");
            }

        }


        private void Task_Click(object sender, EventArgs e)
        {
            // I Need to pass taskId to this function so I can run the query and display the info!!!!
            LinqToSQLCRUD.GetTaskById(5);
            Task task = new Task(taskName);
            
            task.ShowDialog();
        }

        private void DeleteListButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete list '"+ ListNameLabel.Text +"'? \rThis action is not reversible.", "DELETE BOARD!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

    partial class TTask : Form
    {
        //hardcoded responsibles and status, move to DB in the future
        public string[] responsibles = { "Anderson", "John Louis", "Parvir" };
        public string[] status = { "Ongoing", "Completed", "Obstructed" };

        public TTask(string task)
        {
            InitializeComponent();
            TaskNameLabel.Text = task;
            WhoBox.DataSource = responsibles;
            StatusBox.DataSource = status;

        }

        public TTask(int taskId, string taskName, int listId)
        {
            InitializeComponent();
            TaskNameLabel.Text = taskName;
            WhoBox.DataSource = responsibles;
            StatusBox.DataSource = status;

        }

        public TTask(int TaskId, string TaskName, string TaskDescription, DateTime TaskDue, int TaskWho, int TaskStatus, int TaskListId)
        {
            this.TasktId = TaskId; // FIX PROPERTY TYPO LATER... 
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescription;
            this.TaskDue = TaskDue;
            this.TaskWho = TaskWho;
            this.TaskStatus = TaskStatus;
            this.TaskList = TaskListId;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {

        }
    }

    partial class TStatus
    {
    }
}
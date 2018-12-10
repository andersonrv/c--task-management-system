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
    public partial class List : UserControl
    {
        //LinkLabel taskLabel;
        int ListId;

        //Tasks param setup
        string taskName;
        string taskMarker = "\u21DB ";
        Font taskFont = new Font("Arial", 8);
        Color taskLinkColor = Color.Black;
        Color taskActiveLinkColor = Color.Green;
        Random rgb = new Random();
        int minValue = 100;
        int maxValue = 200;


        //List<Task> ListOfTask = new List<Task>();

        public List(int listId, string listName, int boardId)
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
                taskLink.Click += (mySender, myEventArgs) => ViewTask_Click(mySender, myEventArgs, (int)taskLink.Tag);

                taskPanel.Controls.Add(taskLink);
            }
        }

        public List(string listName, int boardId)
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
                taskLink.Click += (mySender, myEventArgs) => ViewTask_Click(mySender, myEventArgs, (int)taskLink.Tag);

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

                //Reading the record on DB to display on FlowLayoutPanel
                var lastTask = LinqToSQLCRUD.GetLastTaskInserted();

                foreach (var result in lastTask)
                {
                    //Task aTask = new Task(result.TasktId, result.TaskName, (int)result.TaskList);
                    //ListOfTask.Add(aTask);

                    LinkLabel taskLink = new LinkLabel();
                    taskLink.Text = taskMarker + result.TaskName + "\n"; //task.TaskName;
                    taskLink.Tag = result.TasktId;
                    taskLink.Font = taskFont;
                    taskLink.LinkColor = taskLinkColor;
                    taskLink.ActiveLinkColor = taskActiveLinkColor;
                    
                    // passing taskId to build up its view on the function ViewTask_Click
                    taskLink.Click += (mySender, myEventArgs) => ViewTask_Click(mySender, myEventArgs, (int)taskLink.Tag);
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

        private void ViewTask_Click(object sender, EventArgs e, int taskId)
        {
            var result = LinqToSQLCRUD.GetTaskById(taskId);

            foreach (var item in result)
            {
                if (item.TaskDescription is null) // when task was created or not modified
                {
                    Task task = new Task(item.TasktId, item.TaskName, (int)item.TaskList);
                    task.DestroyIt += () => Refresh(this.ListId); // it updates the list once a task is delete it
                    task.ShowDialog();
                }
                else // once task was already created and updated
                {
                    Task task = new Task(item.TasktId, item.TaskName, item.TaskDescription, (DateTime)item.TaskDue, (int)item.TaskWho, (int)item.TaskStatus, (int)item.TaskList);
                    task.DestroyIt += () => Refresh(this.ListId);
                    task.ShowDialog();
                }
            }
        }

        private void DeleteListButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete list '" + ListNameLabel.Text + "'? \rThis action is not reversible.", "DELETE BOARD!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Remove from DB
                //string propName = "ListId";
                
                int listIdToBeDeleted = (ListId);//(int)this.GetType().GetProperty(propName).GetValue(this, null);
                LinqToSQLCRUD.DeleteList(listIdToBeDeleted);

                // Destroy component in the ListArea
                this.Dispose();

            }
        }


        private void Refresh(int listId) {


            var tasks = LinqToSQLCRUD.ReadTasks(listId);

            taskPanel.Controls.Clear();

            foreach (var task in tasks)
            {
                LinkLabel taskLink = new LinkLabel();
                taskLink.Text = taskMarker + task.TaskName + "\n"; //task.TaskName;
                taskLink.Tag = task.TasktId;
                taskLink.Font = taskFont;
                taskLink.LinkColor = taskLinkColor;
                taskLink.ActiveLinkColor = taskActiveLinkColor;
                taskLink.Click += (mySender, myEventArgs) => ViewTask_Click(mySender, myEventArgs, (int)taskLink.Tag);

                

                taskPanel.Controls.Add(taskLink);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class Task : Form
    {
        int TasktId;
        string TaskName;
        string TaskDescription;
        DateTime TaskDue;
        int TaskWho;
        int TaskStatus;
        int TaskList;


        //hardcoded responsibles and status, move to DB in the future
        public string[] responsibles = { "Anderson", "John Louis", "Parvir" };
        public string[] status = { "Ongoing", "Completed", "Obstructed" };

        public Task(string task)
        {
            InitializeComponent();
            TaskNameLabel.Text = task;
            WhoBox.DataSource = responsibles;
            StatusBox.DataSource = status;

        }

        public Task(int taskId, string taskName, int listId)
        {
            InitializeComponent();
            TaskNameLabel.Text = taskName;
            WhoBox.DataSource = responsibles;
            StatusBox.DataSource = status;

        }

        public Task(int TaskId, string TaskName, string TaskDescription, DateTime TaskDue, int TaskWho, int TaskStatus, int TaskListId)
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
}

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
        

        //public string[] users = { "Anderson", "John Louis", "Parvir" };
        

        //public string[] status = { "Ongoing", "Completed", "Obstructed" };

        public Task(int taskId, string taskName, int listId)
        {
            InitializeComponent();
            TaskNameLabel.Text = taskName;

            var users = PopulateUserList();
            //WhoBox.DataSource = users;
            WhoBox.DataSource = new BindingSource(users, null);
            WhoBox.DisplayMember = "Value";
            WhoBox.ValueMember = "Key";

            var status = PopulateStatusList();
            StatusBox.DataSource = new BindingSource(status, null);
            StatusBox.DisplayMember = "Value";
            StatusBox.ValueMember = "Key";

            this.TasktId = taskId;
            this.TaskName = taskName;
            this.TaskList = listId;
        }

        //public Task(int TaskId, string TaskName, string TaskDescription, DateTime TaskDue, int TaskWho, int TaskStatus, int TaskListId)
        //{
        //    this.TasktId = TaskId; // FIX PROPERTY TYPO LATER... 
        //    this.TaskName = TaskName;
        //    this.TaskDescription = TaskDescription;
        //    this.TaskDue = TaskDue;
        //    this.TaskWho = TaskWho;
        //    this.TaskStatus = TaskStatus;
        //    this.TaskList = TaskListId;
        //}

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

            var props = this.TasktId;
            Debug.WriteLine(props);
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<int, string> PopulateUserList()
        {
            var result = new Dictionary<int, string>();

            var users = LinqToSQLCRUD.GetUsers();
            foreach (var user in users)
            {
                result.Add(user.UserId, user.UserName);
            }

            return result;
        }

        private Dictionary<int, string> PopulateStatusList()
        {
            var result = new Dictionary<int, string>();

            var status = LinqToSQLCRUD.GetStatus();
            foreach (var record in status)
            {
                result.Add(record.StatusId, record.StatusName);
            }

            return result;
        }
    }
}

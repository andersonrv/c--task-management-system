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
        //string TaskDescription;
        //DateTime TaskDue;
        //int TaskWho;
        //int TaskStatus;
        int TaskList;

        public Task(int taskId, string taskName, int listId)
        {
            InitializeComponent();
            TasktId = taskId;
            TaskName = taskName;
            TaskList = listId;

            TaskNameLabel.Text = taskName;

            var users = PopulateUserList();
            WhoBox.DataSource = new BindingSource(users, null);
            WhoBox.DisplayMember = "Value";
            WhoBox.ValueMember = "Key";

            var status = PopulateStatusList();
            StatusBox.DataSource = new BindingSource(status, null);
            StatusBox.DisplayMember = "Value";
            StatusBox.ValueMember = "Key";

        }

        public Task(int taskId, string taskName, string taskDescription, DateTime taskDue, int taskWho, int taskStatus, int listId)
        {
            InitializeComponent();
            TasktId = taskId;
            TaskName = taskName;
            TaskList = listId;

            TaskNameLabel.Text = taskName;

            TextBoxDescription.Text = taskDescription;

            DueTimePicker.Value = taskDue;

            var users = PopulateUserList();
            WhoBox.DataSource = new BindingSource(users, null);
            WhoBox.DisplayMember = "Value";
            WhoBox.ValueMember = "Key";

            WhoBox.SelectedValue = taskWho;

            var status = PopulateStatusList();
            StatusBox.DataSource = new BindingSource(status, null);
            StatusBox.DisplayMember = "Value";
            StatusBox.ValueMember = "Key";

            StatusBox.SelectedValue = taskStatus;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            var id = this.TasktId;
            string what = TextBoxDescription.Text;
            DateTime when = DueTimePicker.Value;
            KeyValuePair<int, string> selectedWho = (KeyValuePair<int, string>)WhoBox.SelectedItem;
            int who = selectedWho.Key;
            KeyValuePair<int, string> selectedStatus = (KeyValuePair<int, string>)StatusBox.SelectedItem;
            int status = selectedStatus.Key;

            try
            {
                LinqToSQLCRUD.UpdateTask(id, what, when, who, status);
                MessageBox.Show("Task was updated.", "SUCCESS!");
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Your changes were not saved.");
            }


            // ADD A MESSAGE TO LET THE USER KNOW THAT THE UPDATE WAS SUCCESSFUL!!!
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete the current task? \rThis action is not reversible.", "DELETE TASK!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LinqToSQLCRUD.DeleteTask(TasktId);
                // I HAVE TO UPDATE THE LIST WITH THE TASKS AND REMOVE IT FROM THERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // BindingSource.ResetBindings 
                // Use a delegate on the parent and call it from the child.
                // Create an event in the parent and call the event from the child.
                Dispose();
                

            }
            else
            {
                Debug.WriteLine(this.Parent);
            }
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

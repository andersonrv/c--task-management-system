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
    public partial class List : UserControl
    {
        //LinkLabel taskLabel;
        string taskName;
        string taskMarker = "\u21DB ";
        Font taskFont = new Font("Arial", 9);
        Color taskLinkColor = Color.Black;
        Color taskActiveLinkColor = Color.Green;
        Size taskLabelSize = new Size(155, 0);
        bool taskAutoSize = true;

        List<Task> ListOfTask = new List<Task>();
        
        public List()
        {
            InitializeComponent();
            taskPanel.BackColor = Color.White;
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

        }
    }
}

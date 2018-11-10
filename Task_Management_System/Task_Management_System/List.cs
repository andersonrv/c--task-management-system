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
        LinkLabel taskLabel;
        string taskName;
        string taskMarker = "\u21DB ";
        Font taskFont = new Font("Arial", 9);
        Color taskLinkColor = Color.Black;
        Color taskActiveLinkColor = Color.Green;
        Size taskLabelSize = new Size(155, 0);
        bool taskAutoSize = true;




        public List()
        {
            InitializeComponent();
            taskPanel.BackColor = Color.White;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            taskLabel = new LinkLabel();
            taskName = taskInputBox.Text;
            taskLabel.Text = taskMarker + taskName + "\n";
            taskLabel.Font = taskFont;
            taskLabel.MaximumSize = taskLabelSize;
            taskLabel.AutoSize = taskAutoSize;
            taskLabel.LinkColor = taskLinkColor;
            taskLabel.ActiveLinkColor = taskActiveLinkColor;
            taskLabel.Click += Task_Click;
            if (taskName != "")
            {
                taskPanel.Controls.Add(taskLabel);
                taskInputBox.Text = "";
            }    
            
        }

        private void Task_Click(object sender, EventArgs e)
        {
            Task task = new Task(taskName);
            task.ShowDialog();

        }

        
    }
}

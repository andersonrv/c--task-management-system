using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class Task: Form
    {
        TextBox taskBox = new TextBox();
        public int taskHeight = 23;
        int taskWidth = 200;
        PictureBox pb { get; set; }
        public Task(PictureBox listBox)
        {
            pb = listBox;
        }

        public void AddTask(string task,int taskYPosition )
        {
            int taskLength = task.Length * 5;
            while (taskLength > 200)
            {
                taskHeight += 23;
                taskLength -= 200;
            }
            pb.Controls.Add(taskBox);
            taskBox.Multiline = true;
            taskBox.ReadOnly = true;
            taskBox.Height = taskHeight;
            taskBox.Width = taskWidth;
            taskBox.Text = task;
            taskBox.Top = taskYPosition;
        }

    }
}

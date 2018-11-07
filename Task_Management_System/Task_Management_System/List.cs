using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class List : Form
    {
        PictureBox listBox = new PictureBox();
        TextBox taskInput = new TextBox();
        Button addTask = new Button();
        int taskYPosition = 50;
        int topMargin = 5;
        int taskBtnTopMargin = 3;
        public int boxWidth = 200;
        int boxHeight = 300;
        Size taskInputSize = new Size(150, 25);
        Random rgb = new Random();
        Panel _panel { get; set; }

        public List(Panel panel)
        {
            this._panel = panel;
        }

        public void AddList(int xPosition)
        {

            
            addTask.Text = "Add Task";
            listBox.BackColor = Color.FromArgb(rgb.Next(100, 255), rgb.Next(10, 255), rgb.Next(10, 255));
            addTask.BackColor = Color.White;
            listBox.Size = new Size(boxWidth, boxHeight);
            taskInput.Size = taskInputSize;

            _panel.Controls.Add(listBox);
            listBox.Controls.Add(taskInput);
            listBox.Controls.Add(addTask);
            addTask.Top = taskBtnTopMargin + taskInput.Height;
            addTask.Click += AddTask_Click;
            listBox.Top = topMargin;
            listBox.Left = xPosition;
            
        }

    
        private void AddTask_Click(object sender, EventArgs e)
        {

            Task task = new Task(listBox);
            if(taskInput.Text != "")
            {
                task.AddTask(taskInput.Text, taskYPosition);
                taskYPosition += task.taskHeight + 2;
            }
            taskInput.Text = "";
            
        }


    }
}

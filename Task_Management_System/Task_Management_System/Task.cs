﻿using System;
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

        public Task(string task)
        {
            InitializeComponent();
            taskName.Text = task;
        }
    }
}

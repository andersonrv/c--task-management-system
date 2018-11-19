﻿using System;
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
    public partial class BoardContent : UserControl
    {
        protected int BoardId;

        public BoardContent()
        {
            InitializeComponent();
        }

        public BoardContent(int BoarId)
        {
            this.BoardId = BoarId;
            InitializeComponent();
            var lists = LinqToSQLCRUD.ReadLists(BoarId);
            foreach (var list in lists)
            {
                TList listUserControl = new TList(list.ListId, list.ListName, (int)list.BoardId);
                ListArea.Controls.Add(listUserControl);
            }
        }

        Random rgb = new Random();
        int minValue = 100;
        int maxValue = 200;

        List<Task> ListOfTasks = new List<Task>();

        private void AddList_Click(object sender, EventArgs e)
        {
            if (ListNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name for the list.");
            }
            else
            {
                // Adding List to DB
                LinqToSQLCRUD.CreateList(ListNameTextBox.Text, this.BoardId);

                // Adding to ListArea

                var lastList = LinqToSQLCRUD.GetLastListInserted(); // getting Id generated by MSSQL

                foreach (var result in lastList)
                {
                    TList aList = new TList(result.ListId, result.ListName, (int)result.BoardId);
                    aList.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
                    ListArea.Controls.Add(aList);
                }

                ListNameTextBox.Clear();
            }
        }
    }
}
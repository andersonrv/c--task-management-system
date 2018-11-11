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
    public partial class BoardContent : UserControl
    {
        public BoardContent()
        {
            InitializeComponent();
        }

        Random rgb = new Random();
        int minValue = 100;
        int maxValue = 200;

        List<Task> ListOfTasks = new List<Task>();

        private void AddList_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.BackColor = Color.FromArgb(rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue), rgb.Next(minValue, maxValue));
            ListArea.Controls.Add(list);
        }
    }
}

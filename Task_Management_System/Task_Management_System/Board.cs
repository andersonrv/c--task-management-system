using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_System
{
    public class Board : TabPage
    {
        public Board(string name)
        {
            Text = name;
            Controls.Add(new BoardContent());
        }
    }
}

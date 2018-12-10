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
        private string BoardName;
        private int UserId;
        public int BoardId { get; set; }

        public Board(int BoardId, string Name, int UserId)
        {

            this.BoardId = BoardId;
            this.BoardName = Name;
            this.UserId = UserId;

            Text = Name;
            Controls.Add(new BoardContent(this.BoardId));
        }
    }
}

﻿using System;
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
        private int BoardId;

        public Board(string Name, int UserId)
        {
            this.BoardName = Name;
            this.UserId = UserId;
            Text = Name;
            Controls.Add(new BoardContent());
        }

        public Board(string Name, int UserId, int BoardId)
        {
            this.BoardName = Name;
            this.UserId = UserId;
            this.BoardId = BoardId;
            Text = Name;
            Controls.Add(new BoardContent());
        }
    }
}

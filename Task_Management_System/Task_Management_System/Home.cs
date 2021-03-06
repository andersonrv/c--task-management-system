﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Task_Management_System
{
    public partial class Home : Form
    {
        FlowLayoutPanel ListSpace = new FlowLayoutPanel();
        protected int userId;

        public Home(int loggedUser)
        {
            InitializeComponent();
            userId = loggedUser;
            var boards = LinqToSQLCRUD.ReadBoards(userId);
            foreach (var board in boards)
            {
                Board tab = new Board(board.BoardId, board.BoardName, board.BoardId);
                BoardArea.TabPages.Add(tab);
                
            }
        }

        private void AddBoard_Click(object sender, EventArgs e)
        {
            if (BoardNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name for the board.");
            }
            else
            {
                // Adding to DB

                LinqToSQLCRUD.CreateBoard(BoardNameTextBox.Text, userId);

                // Adding to TabControl

                var lastBoard = LinqToSQLCRUD.GetLastBoardInserted();
                
                foreach (var result in lastBoard)
                {
                    Board aBoard = new Board(result.BoardId, result.BoardName, (int)result.UserId);
                    BoardArea.TabPages.Add(aBoard);
                    BoardArea.SelectedTab = aBoard;
                }

                BoardNameTextBox.Clear();
                
            }
        }

        private void DeleteBoard_Click(object sender, EventArgs e)
        {
            if (BoardArea.TabCount > 0)
            {
                if(MessageBox.Show("Do you really want to delete the current board? \rThis action is not reversible.", "DELETE BOARD!" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int boardIdToBeDeleted = (int)BoardArea.SelectedTab.GetType().GetProperty("BoardId").GetValue(BoardArea.SelectedTab, null);
                    LinqToSQLCRUD.DeleteBoard(boardIdToBeDeleted);
                    BoardArea.TabPages.Remove(BoardArea.SelectedTab);
                }
            }
            else
            {
                MessageBox.Show("You do not have any boards to be deleted.");
            }

        }

        private void BoardNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddBoard_Click(this, new EventArgs());
            }
        }
    }
}

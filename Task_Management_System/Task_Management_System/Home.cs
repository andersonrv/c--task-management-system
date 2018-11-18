using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
                TBoard tab = new TBoard(board.BoardId, board.BoardName, board.BoardId);
                BoardArea.TabPages.Add(tab);
            }
        }

        private void AddBoard_Click(object sender, EventArgs e)
        {
            if (BoardNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name for the board");
            }
            else
            {
                //int generateBoardId = (int)(Int64)DateTimeOffset.Now.ToUnixTimeMilliseconds();


                TBoard aBoard = new TBoard(BoardNameTextBox.Text, userId); // We need to make this field editable once a board is created

                LinqToSQLCRUD.CreateBoard(BoardNameTextBox.Text, userId);
            
                BoardArea.TabPages.Add(aBoard);
            }
        }

        private void DeleteBoard_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to delete the current board? \rThis action is not reversible.", "DELETE BOARD!" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BoardArea.TabPages.Remove(BoardArea.SelectedTab);
            }
        }


    }
}

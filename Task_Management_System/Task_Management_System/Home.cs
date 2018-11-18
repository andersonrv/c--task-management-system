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
    public partial class Home : Form
    {
        FlowLayoutPanel ListSpace = new FlowLayoutPanel();
        protected string connectString = "Data Source=199.103.60.77;Initial Catalog=aresendeviana683;Persist Security Info=True;User ID=aresendeviana683;Password=4577695275537560";
        protected int userId;

        public Home(int loggedUser)
        {
            InitializeComponent();
            userId = loggedUser;
        }

        private void AddBoard_Click(object sender, EventArgs e)
        {
            if (BoardNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name for the board");
            }
            else
            {
                Board aBoard = new Board("New Board"); // We need to make this field editable once a board is created

                LinqToSQLCRUD.CreateBoard(BoardNameTextBox.Text, userId, connectString);
            
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

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
        public Home()
        {
            InitializeComponent();
        }

        private void AddBoard_Click(object sender, EventArgs e)
        {
            TabPage aBoard = new TabPage("Board " + (BoardArea.TabPages.Count + 1));
            BoardArea.TabPages.Add(aBoard);
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

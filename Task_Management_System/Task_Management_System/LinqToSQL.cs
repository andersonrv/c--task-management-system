using System.Windows.Forms;

namespace Task_Management_System
{   
    partial class TUser
    {
    }

    partial class TBoard : TabPage
    {
        public TBoard(string Name, int UserId)
        {
            this.BoardName = Name;
            this.UserId = UserId;
            Text = Name;
            Controls.Add(new BoardContent());
        }

        public TBoard(int BoardId, string Name, int UserId)
        {
            this.BoardName = Name;
            this.UserId = UserId;
            this.BoardId = BoardId;
            Text = Name;
            Controls.Add(new BoardContent());
        }
    }

    partial class TBoardAccess
    {
    }

    partial class TList
    {
    }

    partial class TTask
    {
    }

    partial class TStatus
    {
    }
}
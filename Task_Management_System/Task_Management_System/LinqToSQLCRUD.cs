using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class LinqToSQLCRUD
    {
        public static int LoginUser(string UserName, string Pass, string connectString)
        {
            
            LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

            //Look for user in the DB

            TUser user = db.TUsers.FirstOrDefault(u => u.UserName.Equals(UserName));
            if (user.Pass == Pass)
            {
                return user.UserId;
            }
            else
            {
                return 0;
            }

        }

        public static void AddBoard(string BoardName, int UserId, string connectString)
        { 
            
            LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);
            
            //Create new Employee

            TBoard newBoard = new TBoard();
            newBoard.BoardName = BoardName;
            newBoard.UserId = UserId;
            
            //Add new Employee to database
            db.TBoards.InsertOnSubmit(newBoard);

            //Save changes to Database.
            db.SubmitChanges();

        }
    }
}

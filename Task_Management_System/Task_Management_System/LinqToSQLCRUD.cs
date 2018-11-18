using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class LinqToSQLCRUD
    {
        public static int LoginUser(string UserName, string Pass)
        {
            
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Look for user in the DB

            TUser user = db.TUsers.FirstOrDefault(u => u.UserName.Equals(UserName));
            if (user is null)
            {
                return 0;
            }
            else
            {
                if (user.Pass == Pass)
                {
                    return user.UserId;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IEnumerable<TBoard> ReadBoards(int userId)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            var query = db.ExecuteQuery<TBoard>(@"SELECT BoardId, BoardName, UserId
                                                FROM TBoards
                                                WHERE UserId = {0}", userId);

            return query;
        }

        public static void CreateBoard(string BoardName, int UserId)
        { 
            
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Create new Board

            TBoard newBoard = new TBoard
            {
                BoardName = BoardName,
                UserId = UserId
            };

            //db.InsertTBoard(newBoard); //useless
            //Add new Board to database
            db.TBoards.InsertOnSubmit(newBoard);

            Debug.WriteLine(newBoard.BoardId);

            //Save changes to Database.
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }





    }
}

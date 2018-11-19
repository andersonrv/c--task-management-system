﻿using System;
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

        public static IEnumerable<TBoard> GetLastBoardInserted()
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            var query = db.ExecuteQuery<TBoard>(@"SELECT TOP 1 *
                                                FROM TBoards
                                                ORDER BY BoardId DESC");

            return query;
        }

        public static void CreateBoard(string BoardName, int UserId)
        { 
            
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Create new Board
            
            TBoard newBoard = new TBoard()
            {
                BoardName = BoardName,
                UserId = UserId
            };

            //Add new Board to database
            db.TBoards.InsertOnSubmit(newBoard);

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

        public static void DeleteBoard(int BoardId)
        {

            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Get Board to be deleted
            TBoard boardToBeDeleted = db.TBoards.FirstOrDefault(b => b.BoardId.Equals(BoardId));

            //Delete Board on database
            db.TBoards.DeleteOnSubmit(boardToBeDeleted);
            
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

        // Work on update BoardName in the future.

        public static IEnumerable<TList> ReadLists(int boardId)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            var query = db.ExecuteQuery<TList>(@"SELECT ListId, ListName, BoardId
                                                FROM TLists
                                                WHERE BoardId = {0}", boardId);

            return query;
        }

        public static IEnumerable<TList> GetLastListInserted()
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            var query = db.ExecuteQuery<TList>(@"SELECT TOP 1 *
                                                FROM TLists
                                                ORDER BY ListId DESC");

            return query;
        }

        public static void CreateList(string ListName, int BoardId)
        {

            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Create new Board

            TList newList = new TList
            {
                ListName = ListName,
                BoardId = BoardId
            };

            //Add new Board to database
            db.TLists.InsertOnSubmit(newList);

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

        public static void DeleteList(int ListId)
        {

            LinqToSQLDataContext db = new LinqToSQLDataContext();

            //Get Board to be deleted
            TList listToBeDeleted = db.TLists.FirstOrDefault(l => l.ListId.Equals(ListId));

            //Delete Board on database
            db.TLists.DeleteOnSubmit(listToBeDeleted);

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

        // Work on edit ListName in the future.

    }
}

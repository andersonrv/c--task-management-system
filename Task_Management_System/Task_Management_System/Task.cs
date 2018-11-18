using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class Task : Form
    {
        //hardcoded responsibles and status, move to DB in the future
        public string[] responsibles = { "Anderson", "John Louis", "Parvir" };
        public string[] status = { "Ongoing", "Completed", "Obstructed" };



        public Task(string task)
        {
            InitializeComponent();
            TaskNameLabel.Text = task;
            ResponsibleBox.DataSource = responsibles;
            StatusBox.DataSource = status;
            
        }

        //protected LinkLabel _taskLink;
        //public LinkLabel TaskLink
        //{
        //    get { return _taskLink; }
        //    set
        //    {
        //        string taskName;
        //        string taskMarker = "\u21DB ";
        //        Font taskFont = new Font("Arial", 9);
        //        Color taskLinkColor = Color.Black;
        //        Color taskActiveLinkColor = Color.Green;
        //        Size taskLabelSize = new Size(155, 0);
        //        bool taskAutoSize = true;

        //        Text = taskMarker + taskName + "\n";
        //        Font = taskFont;
        //        MaximumSize = taskLabelSize;
        //        AutoSize = taskAutoSize;
        //        LinkLabel.LinkColor = taskLinkColor;
        //        ActiveLinkColor = taskActiveLinkColor;
        //        Click += Task_Click;
        //    }
        //}

        protected int _taskID;
        public int TaskID
        {
            get { return _taskID; }
            set
            {
                _taskID = value;
            }    
        }

        protected string _taskName;
        public string TaskName
        {
            get { return _taskName; }
            set
            {
                _taskName = TaskNameLabel.Text;
            }
        }

        protected string _taskDescription;
        public string TaskDescription
        {
            get { return _taskDescription; }
            set
            {
                _taskDescription = TextBoxDescription.Text;
            }
        }

        protected DateTime _taskDue;
        public DateTime TaskDue
        {
            get { return _taskDue; }
            set
            {
                _taskDue = TaskDateTimePicker.Value;
            }
        }
        
        protected string _responsible;
        public string Responsible
        {
            get { return _responsible; }
            set
            {
                _responsible = ResponsibleBox.Text;
            }
        }

        protected string _status;
        public string Status
        {
            get { return _status; }
            set
            {
                _status = StatusBox.Text;
            }
        }
    }
}

namespace Task_Management_System
{
    partial class BoardContent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListArea = new System.Windows.Forms.FlowLayoutPanel();
            this.AddList = new System.Windows.Forms.Button();
            this.ListNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListArea
            // 
            this.ListArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListArea.AutoScroll = true;
            this.ListArea.Location = new System.Drawing.Point(22, 66);
            this.ListArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(1258, 780);
            this.ListArea.TabIndex = 7;
            this.ListArea.WrapContents = false;
            // 
            // AddList
            // 
            this.AddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddList.Location = new System.Drawing.Point(20, 10);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(160, 48);
            this.AddList.TabIndex = 6;
            this.AddList.Text = "+ List";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // ListNameTextBox
            // 
            this.ListNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameTextBox.Location = new System.Drawing.Point(187, 11);
            this.ListNameTextBox.Name = "ListNameTextBox";
            this.ListNameTextBox.Size = new System.Drawing.Size(459, 39);
            this.ListNameTextBox.TabIndex = 0;
            this.ListNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListNameTextBox_KeyDown);
            // 
            // BoardContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListNameTextBox);
            this.Controls.Add(this.ListArea);
            this.Controls.Add(this.AddList);
            this.Name = "BoardContent";
            this.Size = new System.Drawing.Size(1300, 856);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListArea;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.TextBox ListNameTextBox;
    }
}

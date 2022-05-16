namespace Baldwin_Asg9_SP
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddToEnd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddToBeginning = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCopyPasteTab = new System.Windows.Forms.Button();
            this.buttonCopyPasteCrlf = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxMatchingExcluded = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSortAscending = new System.Windows.Forms.Button();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.checkBoxNoDupes = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonSqlWithQuotes = new System.Windows.Forms.Button();
            this.buttonSqlNoQuotes = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beginning:";
            // 
            // textBoxAddToEnd
            // 
            this.textBoxAddToEnd.Location = new System.Drawing.Point(69, 43);
            this.textBoxAddToEnd.Name = "textBoxAddToEnd";
            this.textBoxAddToEnd.Size = new System.Drawing.Size(247, 20);
            this.textBoxAddToEnd.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddText);
            this.groupBox1.Controls.Add(this.textBoxAddToBeginning);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAddToEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to Beginning / End of Each Line";
            // 
            // buttonAddText
            // 
            this.buttonAddText.Location = new System.Drawing.Point(331, 26);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(75, 29);
            this.buttonAddText.TabIndex = 3;
            this.buttonAddText.Text = "Add Text";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End:";
            // 
            // textBoxAddToBeginning
            // 
            this.textBoxAddToBeginning.Location = new System.Drawing.Point(69, 17);
            this.textBoxAddToBeginning.Name = "textBoxAddToBeginning";
            this.textBoxAddToBeginning.Size = new System.Drawing.Size(247, 20);
            this.textBoxAddToBeginning.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonReplace);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxReplace);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 144);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search And Replace";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(331, 26);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 29);
            this.buttonReplace.TabIndex = 3;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(69, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(247, 20);
            this.textBoxSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search:";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(69, 43);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(247, 20);
            this.textBoxReplace.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Replace:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCopyPasteCrlf);
            this.groupBox3.Controls.Add(this.buttonCopyPasteTab);
            this.groupBox3.Location = new System.Drawing.Point(6, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Copy these special characters to the clipboard for copy/paste";
            // 
            // buttonCopyPasteTab
            // 
            this.buttonCopyPasteTab.Location = new System.Drawing.Point(6, 19);
            this.buttonCopyPasteTab.Name = "buttonCopyPasteTab";
            this.buttonCopyPasteTab.Size = new System.Drawing.Size(75, 29);
            this.buttonCopyPasteTab.TabIndex = 8;
            this.buttonCopyPasteTab.Text = "[TAB]";
            this.buttonCopyPasteTab.UseVisualStyleBackColor = true;
            this.buttonCopyPasteTab.Click += new System.EventHandler(this.buttonCopyPasteTab_Click);
            // 
            // buttonCopyPasteCrlf
            // 
            this.buttonCopyPasteCrlf.Location = new System.Drawing.Point(103, 19);
            this.buttonCopyPasteCrlf.Name = "buttonCopyPasteCrlf";
            this.buttonCopyPasteCrlf.Size = new System.Drawing.Size(75, 29);
            this.buttonCopyPasteCrlf.TabIndex = 9;
            this.buttonCopyPasteCrlf.Text = "[CRLF]";
            this.buttonCopyPasteCrlf.UseVisualStyleBackColor = true;
            this.buttonCopyPasteCrlf.Click += new System.EventHandler(this.buttonCopyPasteCrlf_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxMatchingExcluded);
            this.groupBox4.Controls.Add(this.buttonFind);
            this.groupBox4.Controls.Add(this.textBoxFind);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 64);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find Lines Matching or Not Matching";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Find:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(69, 16);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(247, 20);
            this.textBoxFind.TabIndex = 6;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(331, 19);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 29);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxMatchingExcluded
            // 
            this.checkBoxMatchingExcluded.AutoSize = true;
            this.checkBoxMatchingExcluded.Location = new System.Drawing.Point(69, 42);
            this.checkBoxMatchingExcluded.Name = "checkBoxMatchingExcluded";
            this.checkBoxMatchingExcluded.Size = new System.Drawing.Size(111, 17);
            this.checkBoxMatchingExcluded.TabIndex = 8;
            this.checkBoxMatchingExcluded.Text = "Exclude Matching";
            this.checkBoxMatchingExcluded.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClear);
            this.groupBox5.Controls.Add(this.buttonUndo);
            this.groupBox5.Controls.Add(this.buttonRedo);
            this.groupBox5.Location = new System.Drawing.Point(848, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(96, 144);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Undo/Redo";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(10, 17);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 31);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(10, 59);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(75, 31);
            this.buttonRedo.TabIndex = 10;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(10, 102);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 31);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxNoDupes);
            this.groupBox6.Controls.Add(this.buttonSortDescending);
            this.groupBox6.Controls.Add(this.buttonSortAscending);
            this.groupBox6.Location = new System.Drawing.Point(848, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(96, 125);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sort Results";
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Location = new System.Drawing.Point(10, 19);
            this.buttonSortAscending.Name = "buttonSortAscending";
            this.buttonSortAscending.Size = new System.Drawing.Size(75, 31);
            this.buttonSortAscending.TabIndex = 12;
            this.buttonSortAscending.Text = "Ascending";
            this.buttonSortAscending.UseVisualStyleBackColor = true;
            this.buttonSortAscending.Click += new System.EventHandler(this.buttonSortAscending_Click);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Location = new System.Drawing.Point(10, 56);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(75, 31);
            this.buttonSortDescending.TabIndex = 13;
            this.buttonSortDescending.Text = "Descending";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // checkBoxNoDupes
            // 
            this.checkBoxNoDupes.AutoSize = true;
            this.checkBoxNoDupes.Location = new System.Drawing.Point(10, 98);
            this.checkBoxNoDupes.Name = "checkBoxNoDupes";
            this.checkBoxNoDupes.Size = new System.Drawing.Size(74, 17);
            this.checkBoxNoDupes.TabIndex = 10;
            this.checkBoxNoDupes.Text = "No Dupes";
            this.checkBoxNoDupes.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonSqlWithQuotes);
            this.groupBox7.Controls.Add(this.buttonSqlNoQuotes);
            this.groupBox7.Location = new System.Drawing.Point(848, 293);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(96, 101);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Make SQL IN ";
            // 
            // buttonSqlWithQuotes
            // 
            this.buttonSqlWithQuotes.Location = new System.Drawing.Point(10, 17);
            this.buttonSqlWithQuotes.Name = "buttonSqlWithQuotes";
            this.buttonSqlWithQuotes.Size = new System.Drawing.Size(75, 31);
            this.buttonSqlWithQuotes.TabIndex = 9;
            this.buttonSqlWithQuotes.Text = "W/Quotes";
            this.buttonSqlWithQuotes.UseVisualStyleBackColor = true;
            this.buttonSqlWithQuotes.Click += new System.EventHandler(this.buttonSqlWithQuotes_Click);
            // 
            // buttonSqlNoQuotes
            // 
            this.buttonSqlNoQuotes.Location = new System.Drawing.Point(10, 59);
            this.buttonSqlNoQuotes.Name = "buttonSqlNoQuotes";
            this.buttonSqlNoQuotes.Size = new System.Drawing.Size(75, 31);
            this.buttonSqlNoQuotes.TabIndex = 10;
            this.buttonSqlNoQuotes.Text = "No Quotes";
            this.buttonSqlNoQuotes.UseVisualStyleBackColor = true;
            this.buttonSqlNoQuotes.Click += new System.EventHandler(this.buttonSqlNoQuotes_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(12, 157);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(830, 366);
            this.textBoxData.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 528);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Baldwin Asg9 SP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddToEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.TextBox textBoxAddToBeginning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCopyPasteCrlf;
        private System.Windows.Forms.Button buttonCopyPasteTab;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxMatchingExcluded;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxNoDupes;
        private System.Windows.Forms.Button buttonSortDescending;
        private System.Windows.Forms.Button buttonSortAscending;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonSqlWithQuotes;
        private System.Windows.Forms.Button buttonSqlNoQuotes;
        private System.Windows.Forms.TextBox textBoxData;
    }
}


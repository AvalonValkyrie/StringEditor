using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldwin_Asg9_SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method Def Area Start
        List<String> undoList = new List<String>();
        List<String> redoList = new List<String>();

        private void addToUndoListList()
        {
            String lastData = "";
            if (undoList.Count > 0)
            {
                lastData = undoList[undoList.Count - 1];
            }
            if (lastData != textBoxData.Text)
                undoList.Add(textBoxData.Text);

        }//End of addToUndoListList()

        private void addToRedoListList()
        {
            String lastData = "";
            if (redoList.Count > 0)
            {
                lastData = redoList[redoList.Count - 1];
            }
            if (lastData != textBoxData.Text)
                redoList.Add(textBoxData.Text);
        }//End of addToRedoListList()

        private void loadLastData()
        {
            String lastData = "";
            if (undoList.Count > 0)
            {
                lastData = undoList[undoList.Count - 1];
                
                undoList.RemoveAt(undoList.Count - 1);
                textBoxData.Text = lastData;
            }
        }//end of loadLastData()

        private void loadLastRedoData()
        {
            String lastData = "";
            if (redoList.Count > 0)
            {
                lastData = redoList[redoList.Count - 1];
                
                redoList.RemoveAt(redoList.Count - 1);
                textBoxData.Text = lastData;
            }
        }//End of loadLastRedoData()

        private String[] getStringArrayFromData()
        {
            String[] dataArray;
            dataArray = textBoxData.Text.Split('\n');
            return dataArray;
        }//End of getStringArrayFromData()

        //Method Def Area End
        //Button Area Start
        private void btnClear_Click(object sender, EventArgs e)
        {
            addToUndoListList();
            textBoxData.Clear();


        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            addToUndoListList();
            textBoxData.Clear();


        }//end of clear button

        private void buttonAddText_Click(object sender, EventArgs e)
        {
            String[] arrayString = getStringArrayFromData();

            String prefix = textBoxAddToBeginning.Text + "";
            String postfix = textBoxAddToEnd.Text + "";

            String tempString = "";
            foreach (String line in arrayString)
            {
                tempString = tempString + prefix + line + postfix + Environment.NewLine;
            }

            tempString = tempString.Substring(0, tempString.Length - 2);

            textBoxData.Text = tempString;
        }//end of add to beginning/end button

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            addToUndoListList();

            String temp = textBoxData.Text + "";
            String find = textBoxSearch.Text + ""; ;
            String replace = textBoxReplace.Text + ""; ;

            if (find.IndexOf("[CRLF]") > -1)
                find = find.Replace("[CRLF]", Environment.NewLine);

            if (find.IndexOf("[TAB]") > -1)
                find = find.Replace("[TAB]", "\t");

            if (replace.IndexOf("[CRLF]") > -1)
                replace = replace.Replace("[CRLF]", Environment.NewLine);

            if (replace.IndexOf("[TAB]") > -1)
                replace = replace.Replace("[TAB]", "\t");

            temp = temp.Replace(find, replace);
            textBoxData.Text = temp;
        }//end of replace button

        private void buttonCopyPasteCrlf_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[CRLF]");
        }//End of [CRLF] Button

        private void buttonCopyPasteTab_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[TAB]");
        }//End of [TAB] Button

        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            String[] arrayString = getStringArrayFromData();
            Array.Sort(arrayString, StringComparer.InvariantCulture);

            if (checkBoxNoDupes.Checked == true)
                arrayString = arrayString.Distinct().ToArray();

            String tempString = "";
            foreach (String line in arrayString)
            {
                tempString += line + Environment.NewLine;
            }

            textBoxData.Text = tempString;
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            String[] arrayString = getStringArrayFromData();
            Array.Sort(arrayString, StringComparer.InvariantCulture);
            Array.Reverse(arrayString);

            if (checkBoxNoDupes.Checked == true)
                arrayString = arrayString.Distinct().ToArray();

            String tempString = "";
            foreach (String line in arrayString)
            {
                tempString += line + Environment.NewLine;
            }

            textBoxData.Text = tempString;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            addToUndoListList();
            String[] arrayString = getStringArrayFromData();
            String find = textBoxFind.Text;
            String tempString = "";

            try
            {
                if (checkBoxMatchingExcluded.Checked == true)
                {
                    foreach (String line in arrayString)
                    {
                        if ((line.Contains(find)) == false)
                        {
                            tempString = (tempString + line + Environment.NewLine);
                        }
                    }
                    tempString = tempString.Substring(0, tempString.Length - 2);
                }
                else
                {
                    foreach (String line in arrayString)
                    {
                        if ((line.Contains(find)) == true)
                        {
                            tempString = (tempString + line + Environment.NewLine);
                        }
                    }
                    tempString = tempString.Substring(0, tempString.Length - 2);
                }
            }
            catch
            {
                tempString = ("We have encountered an error," + Environment.NewLine + "please re-enter your values, as this may have been caused by our program returning less than one value from the list given to it.");
            }

            textBoxData.Text = tempString;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            addToRedoListList();
            loadLastData();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            loadLastRedoData();
        }

        private void buttonSqlWithQuotes_Click(object sender, EventArgs e)
        {
            addToUndoListList();
            String[] arrayString = getStringArrayFromData();
            String temp = "";
            foreach (String line in arrayString)
            {
                temp = (temp + line + "','");
            }
            
            temp = temp.Substring(0, temp.Length - 2);
            temp = "in('" + temp + ")";
            textBoxData.Text = temp;
        }//end of sql with quotes

        private void buttonSqlNoQuotes_Click(object sender, EventArgs e)
        {
            addToUndoListList();
            String[] arrayString = getStringArrayFromData();
            String temp = "";
            foreach (String line in arrayString)
            {
                temp = (temp + line + ",");
            }

            temp = temp.Substring(0, temp.Length - 1);
            temp = "in(" + temp + ")";
            textBoxData.Text = temp;
        }//end of sql without quotes

        //Button Area End
    }
}

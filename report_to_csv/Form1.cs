using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report_to_csv
{
    public partial class Form1 : Form
    {
        //const string fileRoot = "crer-svc-weblogicsit";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string fileRoot = txtRoot.Text;
            List<ScanItem> items = new List<ScanItem>();
            ScanItem temp = null;
            for (int i = 0; i < txtIn.Lines.Length; i++) {                
                if (temp == null)
                    temp = new ScanItem();

                if (txtIn.Lines[i].EndsWith("\\Path 1:"))
                {
                    temp.Catagory = txtIn.Lines[i].Replace("\\Path 1:", "");
                }
                if (txtIn.Lines[i].StartsWith("File ") && !txtIn.Lines[i].StartsWith("File Name")) {
                    temp.SrcFile = txtIn.Lines[i];
                    bool filePathDone = false;
                    for (int j = i + 1; j < txtIn.Lines.Length; j++)
                    {
                        if (txtIn.Lines[j].StartsWith(fileRoot))
                            filePathDone = true;
                        if (txtIn.Lines[j].StartsWith("Line"))
                        {
                            temp.SrcLine = txtIn.Lines[j];
                            break;
                        }                            
                        else if (!filePathDone)
                            temp.SrcFile += txtIn.Lines[j];

                    }

                    for (int k = i + 1; k < txtIn.Lines.Length; k++)
                    {
                        if (txtIn.Lines[k].StartsWith("Object"))
                        {
                            temp.SrcObject = txtIn.Lines[k];
                            break;
                        }

                    }

                    items.Add(temp);
                    temp = null;
                }
            }
            txtOut.Text = string.Join("\n", items.Select(i => i.ToString()));
        }

        private class ScanItem {
            string catagory;
            string srcFile;
            string srcLine;
            string srcObject;

            public string SrcFile { get => srcFile; set => srcFile = value.Replace("File ","").Trim(); }
            public string SrcLine { get => srcLine; set => srcLine = value.Replace("Line ", "").Trim().Split(' ')[0]; }
            public string SrcObject { get => srcObject; set => srcObject = value.Replace("Object ", "").Trim().Split(' ')[0]; }
            public string Catagory { get => catagory; set => catagory = value; }

            public override string ToString() {
                return string.Format("{0}\t{1}\t{2}\t{3}", catagory, srcFile, srcLine, srcObject);
            }
        }
    }
}

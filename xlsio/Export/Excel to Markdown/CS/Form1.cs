#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO.Implementation;
using Syncfusion.ExcelChartToImageConverter;
using System.IO;
using System.Reflection;

namespace ExceltoMarkdown
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excelToMarkdownConvertBtnClick(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = "";
#if NETCORE
            inputPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelToMarkdownTemplate.xlsx";
#else
            inputPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelToMarkdownTemplate.xlsx";
#endif
            ExcelEngine engine = new ExcelEngine();
            IApplication application = engine.Excel;
            IWorkbook book = application.Workbooks.Open(inputPath);

            //Save the markdown file
            book.SaveAs("ExceltoMarkdown.md", ExcelSaveType.Markdown);

            //Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the Markdown file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("ExceltoMarkdown.md")
                        {
                            UseShellExecute = true
                        };
                        process.Start();
#else
                    Process.Start("ExceltoMarkdown.md");
#endif
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = "";
#if NETCORE
            inputPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelToMarkdownTemplate.xlsx";
#else
            inputPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\XlsIO\ExcelToMarkdownTemplate.xlsx";
#endif
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(inputPath)
            {
                UseShellExecute = true
            };
            process.Start();
#else
            Process.Start(inputPath);
#endif
        }
    }
}
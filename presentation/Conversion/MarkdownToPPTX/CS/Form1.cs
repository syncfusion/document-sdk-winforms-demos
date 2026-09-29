using Syncfusion.Licensing;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Presentation;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarkdownToPPTX
{
    public partial class Form1 : MetroForm 
    {
        #region Private Members
        private System.Windows.Forms.Button btnMarkdownToPPTX;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Label label1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
            this.txtFile.Text = "MarkdownToPPTX.md";
#if !NETCore
            this.txtFile.Tag = @"..\..\..\..\..\..\common\Data\Presentation\MarkdownToPPTX.md";
#else
            this.txtFile.Tag = @"..\..\..\..\..\..\..\common\Data\Presentation\MarkdownToPPTX.md";
#endif
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMarkdownToPPTX = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMarkdownToPPTX
            // 
            this.btnMarkdownToPPTX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkdownToPPTX.Location = new System.Drawing.Point(252, 190);
            this.btnMarkdownToPPTX.Name = "btnMarkdownToPPTX";
            this.btnMarkdownToPPTX.Size = new System.Drawing.Size(123, 24);
            this.btnMarkdownToPPTX.TabIndex = 0;
            this.btnMarkdownToPPTX.Text = "Convert to PPTX";
            this.btnMarkdownToPPTX.UseVisualStyleBackColor = true;
            this.btnMarkdownToPPTX.Click += new System.EventHandler(this.btnMarkdownToPPTX_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(0, 164);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(333, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(346, 162);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click the button to view the converted PPTX document generated by \r\nEssential Presentation. Thi" +
            "s sample illustrates the conversion of\r\nMarkdown document to Microsoft PowerPoint Presentation(PPTX).";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnMarkdownToPPTX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markdown To PPTX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        #region Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
#if !NETCore
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\common\Data\Presentation\");
#else
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\..\common\Data\Presentation\");
#endif
            openFileDialog1.Filter = "Markdown Document(*.md) |*.md";
            DialogResult result = openFileDialog1.ShowDialog();

            //Get the selected file name and display in a TextBox
            if (result == DialogResult.OK)
            {
                this.txtFile.Text = openFileDialog1.SafeFileName;
                this.txtFile.Tag = openFileDialog1.FileName;
            }

        }
        private void btnMarkdownToPPTX_Click(object sender, EventArgs e)
        {
            try
            {
                //Opens the specified Markdown document.
                IPresentation presentation = Presentation.Open(txtFile.Tag.ToString());
                presentation.Save("MarkdownToPPTX.pptx");

                if (MessageBox.Show("Do you want to view the generated PPTX document ? ", "Document has been created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
#if !NETCore
                    System.Diagnostics.Process.Start("MarkdownToPPTX.pptx");
#else
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo("MarkdownToPPTX.pptx")
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#endif
                    this.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be converted , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);
                this.Close();
            }
        }
        #endregion
    }
}

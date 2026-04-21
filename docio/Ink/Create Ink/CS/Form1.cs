#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Licensing;
using Syncfusion.Office;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace EssentialDocIOSamples
{

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv buttonAdv1;
        private ButtonAdv buttonAdv2;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
            Application.EnableVisualStyles();
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
            int levelsToCheck = 12;
            string filePath = @"common\SyncfusionLicense.txt";

            string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            for (int n = 0; n < levelsToCheck; n++)
            {
                string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                if (System.IO.File.Exists(fileDataPath))
                    return File.ReadAllText(fileDataPath, Encoding.UTF8);
                DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                if (rootDirectory == null)
                    break;
                rootPath = rootDirectory.FullName;
            }
            return string.Empty;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
		    SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(108, 22);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(223, 152);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(108, 22);
            this.buttonAdv1.TabIndex = 62;
            this.buttonAdv1.Text = "View Template";
            this.buttonAdv1.ThemeName = "Metro";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.View_Button_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(108, 22);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv2.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(223, 180);
            this.buttonAdv2.Name = "buttonAdv1";
            this.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv2.Size = new System.Drawing.Size(108, 22);
            this.buttonAdv2.TabIndex = 62;
            this.buttonAdv2.Text = "Generate";
            this.buttonAdv2.ThemeName = "Metro";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 61);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 38);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // wordDocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(60, 16);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(6, 16);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(60, 16);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(48, 16);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(77, 17);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(48, 16);
            this.pdfRadioBtn.TabIndex = 45;
            this.pdfRadioBtn.Text = "PDF";
            this.pdfRadioBtn.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(370, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Ink";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void Generate_Button_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Get Template document and database path.
                string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\";
                //Loads the template document.
                WordDocument document = new WordDocument(Path.Combine(dataPath, @"CreateInkInput.docx"));

                // Get last paragraph of the document.
                WParagraph paragraph = document.LastParagraph;

                // Append an ink object to the paragraph.
                WInk inkObj = paragraph.AppendInk(80, 20);
                // Get the traces collection from the ink object (traces represent the drawing strokes)
                IOfficeInkTraces traces = inkObj.Traces;
                // Retrieve an array of points that define the path of the ink stroke
                PointF[] tracePoints = GetPoints();
                // Add a new trace (stroke) to the traces collection using the retrieved points
                IOfficeInkTrace trace = traces.Add(tracePoints);

                // Configure the appearance of the ink
                // Get the brush object associated with the trace to configure its appearance
                IOfficeInkBrush brush = trace.Brush;
                // Set the ink effect type to None (Pen effect applied)
                brush.InkEffect = OfficeInkEffectType.None;
                // Set the color of the ink stroke
                brush.Color = Color.Black;
                // Set the size (thickness) of the ink stroke to 1.5 units
                brush.Size = new SizeF(1.5f, 1.5f);

                //Save as docx format
                if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("CreateInk.docx", FormatType.Docx);
                    //Close the document.
                    document.Close();
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("CreateInk.docx") { UseShellExecute = true };
                            process.Start();
#else
                            System.Diagnostics.Process.Start("CreateInk.docx");
#endif
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as pdf format
                else if (pdfRadioBtn.Checked)
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    //Save the pdf file
                    pdfDoc.Save("CreateInk.pdf");
                    converter.Dispose();
                    pdfDoc.Close();
                    document.Close();
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("CreateInk.pdf") { UseShellExecute = true };
                            process.Start();
#else
                            System.Diagnostics.Process.Start("CreateInk.pdf");
#endif

                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxAdv.Show("PDF Viewer is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Gets the array of trace points defining the signature.
        /// </summary>
        /// <returns>Array of <see cref="PointF"/> representing the path coordinates.</returns>
        public PointF[] GetPoints()
        {
            PointF[] tracePoints = new PointF[95];

            tracePoints[0] = new PointF(15f, 35f);
            tracePoints[1] = new PointF(18f, 28f);
            tracePoints[2] = new PointF(22f, 22f);
            tracePoints[3] = new PointF(27f, 17f);
            tracePoints[4] = new PointF(32f, 14f);
            tracePoints[5] = new PointF(37f, 12f);
            tracePoints[6] = new PointF(42f, 12f);
            tracePoints[7] = new PointF(46f, 14f);
            tracePoints[8] = new PointF(49f, 18f);
            tracePoints[9] = new PointF(51f, 23f);
            tracePoints[10] = new PointF(52f, 28f);
            tracePoints[11] = new PointF(52f, 33f);
            tracePoints[12] = new PointF(51f, 38f);
            tracePoints[13] = new PointF(49f, 42f);
            tracePoints[14] = new PointF(46f, 45f);
            tracePoints[15] = new PointF(42f, 47f);
            tracePoints[16] = new PointF(38f, 48f);
            tracePoints[17] = new PointF(34f, 47f);
            tracePoints[18] = new PointF(31f, 45f);
            tracePoints[19] = new PointF(35f, 42f);
            tracePoints[20] = new PointF(40f, 39f);
            tracePoints[21] = new PointF(46f, 37f);
            tracePoints[22] = new PointF(52f, 36f);
            tracePoints[23] = new PointF(58f, 36f);
            tracePoints[24] = new PointF(63f, 37f);
            tracePoints[25] = new PointF(67f, 40f);
            tracePoints[26] = new PointF(69f, 44f);
            tracePoints[27] = new PointF(69f, 48f);
            tracePoints[28] = new PointF(67f, 51f);
            tracePoints[29] = new PointF(64f, 53f);
            tracePoints[30] = new PointF(60f, 54f);
            tracePoints[31] = new PointF(56f, 53f);
            tracePoints[32] = new PointF(54f, 51f);
            tracePoints[33] = new PointF(53f, 48f);
            tracePoints[34] = new PointF(54f, 45f);
            tracePoints[35] = new PointF(57f, 43f);
            tracePoints[36] = new PointF(61f, 42f);
            tracePoints[37] = new PointF(65f, 42f);
            tracePoints[38] = new PointF(69f, 43f);
            tracePoints[39] = new PointF(73f, 44f);
            tracePoints[40] = new PointF(77f, 43f);
            tracePoints[41] = new PointF(81f, 40f);
            tracePoints[42] = new PointF(84f, 44f);
            tracePoints[43] = new PointF(86f, 48f);
            tracePoints[44] = new PointF(88f, 52f);
            tracePoints[45] = new PointF(90f, 55f);
            tracePoints[46] = new PointF(92f, 52f);
            tracePoints[47] = new PointF(94f, 48f);
            tracePoints[48] = new PointF(96f, 44f);
            tracePoints[49] = new PointF(98f, 40f);
            tracePoints[50] = new PointF(100f, 37f);
            tracePoints[51] = new PointF(104f, 36f);
            tracePoints[52] = new PointF(107f, 38f);
            tracePoints[53] = new PointF(109f, 42f);
            tracePoints[54] = new PointF(110f, 46f);
            tracePoints[55] = new PointF(110f, 50f);
            tracePoints[56] = new PointF(109f, 53f);
            tracePoints[57] = new PointF(112f, 51f);
            tracePoints[58] = new PointF(116f, 48f);
            tracePoints[59] = new PointF(120f, 46f);
            tracePoints[60] = new PointF(125f, 45f);
            tracePoints[61] = new PointF(130f, 46f);
            tracePoints[62] = new PointF(134f, 48f);
            tracePoints[63] = new PointF(137f, 51f);
            tracePoints[64] = new PointF(138f, 54f);
            tracePoints[65] = new PointF(137f, 57f);
            tracePoints[66] = new PointF(134f, 58f);
            tracePoints[67] = new PointF(130f, 58f);
            tracePoints[68] = new PointF(126f, 56f);
            tracePoints[69] = new PointF(124f, 53f);
            tracePoints[70] = new PointF(123f, 49f);
            tracePoints[71] = new PointF(125f, 45f);
            tracePoints[72] = new PointF(127f, 40f);
            tracePoints[73] = new PointF(129f, 35f);
            tracePoints[74] = new PointF(131f, 30f);
            tracePoints[75] = new PointF(133f, 25f);
            tracePoints[76] = new PointF(135f, 20f);
            tracePoints[77] = new PointF(140f, 25f);
            tracePoints[78] = new PointF(148f, 32f);
            tracePoints[79] = new PointF(158f, 38f);
            tracePoints[80] = new PointF(170f, 43f);
            tracePoints[81] = new PointF(182f, 46f);
            tracePoints[82] = new PointF(190f, 47f);
            tracePoints[83] = new PointF(185f, 48f);
            tracePoints[84] = new PointF(175f, 50f);
            tracePoints[85] = new PointF(160f, 52f);
            tracePoints[86] = new PointF(140f, 54f);
            tracePoints[87] = new PointF(115f, 55f);
            tracePoints[88] = new PointF(85f, 56f);
            tracePoints[89] = new PointF(60f, 56f);
            tracePoints[90] = new PointF(40f, 55f);
            tracePoints[91] = new PointF(25f, 53f);
            tracePoints[92] = new PointF(15f, 50f);
            tracePoints[93] = new PointF(10f, 47f);
            tracePoints[94] = new PointF(8f, 44f);

            return tracePoints;
        }
        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_Button_Click(object sender, EventArgs e)
        {
#if NETCORE
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\CreateInkInput.docx") { UseShellExecute = true };
            process.Start();
#else
            System.Diagnostics.Process.Start(Application.StartupPath + @"\..\..\..\..\..\..\common\Data\DocIO\CreateInkInput.docx");
#endif
        }
        #endregion
    }
}


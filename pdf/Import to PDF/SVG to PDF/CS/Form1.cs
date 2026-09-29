using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms;

namespace SVGtoPDF_2005
{
    public partial class Form1 : MetroForm
    {
        // Maximum allowed SVG file size (10 MB).
        private const long MaxFileSize = 10 * 1024 * 1024;

        public Form1()
        {
            InitializeComponent();
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
        }


        private void btnSVG2PDF_Click(object sender, EventArgs e)
        {
            if ((string)this.textBox1.Tag != String.Empty)
            {
                // Validate the SVG file size (10 MB limit).
                if (!IsValidFileSize((string)textBox1.Tag))
                {
                    MessageBox.Show("The selected SVG file exceeds the maximum allowed size of 10 MB.", "File size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Initialize SVG converter.
                SvgConverter converter = new SvgConverter();

                //Convert the SVG file to PDF template.
                PdfTemplate temp = converter.Convert((string)textBox1.Tag);

                //Create a new PDF document and draw the PDF template to the page.
                PdfDocument document = new PdfDocument();
                document.PageSettings.Margins.All = 0;
                document.PageSettings.Size = new SizeF(temp.Width, temp.Height);
                PdfPage page = document.Pages.Add();

                //Draw the PDF template to the page.
                page.Graphics.DrawPdfTemplate(temp, new PointF(0, 0), new SizeF(temp.Width, temp.Height));

                // Save & close the pdf file.
                document.Save("SVGtoPDF.pdf");
                document.Close(true);

                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(@"SVGToPDF.pdf")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                        System.Diagnostics.Process.Start(@"SVGToPDF.pdf");
#endif
                        //Exit
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Browse a SVG Image and click the button to convert as a PDF.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "SVGtoPDF.svg";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\Common\Data\PDF\SVGtoPDF.svg";
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\Common\Data\PDF\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Svg files (*.SVG)|*.svg";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Validate the SVG file size (10 MB limit).
                if (!IsValidFileSize(openFileDialog1.FileName))
                {
                    MessageBox.Show("The selected SVG file exceeds the maximum allowed size of 10 MB. Please select a smaller file.", "File size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox1.Text = string.Empty;
                    this.textBox1.Tag = string.Empty;
                    return;
                }

                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Validates whether the given file is within the maximum allowed size (10 MB).
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <returns>True if the file exists and is within the size limit</returns>
        private bool IsValidFileSize(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return false;

            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Exists && fileInfo.Length <= MaxFileSize;
        }
		 /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\Common\";
#else
            string fullPath = @"..\..\..\..\..\..\Common\";
#endif
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
    }	
}

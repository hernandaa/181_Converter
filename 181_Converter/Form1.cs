using Aspose.Cells;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181_Converter
{
    public partial class Form1 : Form
    {
        DataTable dtNasabah = new DataTable();

        public Form1()
        {
            InitializeComponent();
            initialDeclarement();
        }

        protected void initialDeclarement()
        {
            dtNasabah.Columns.Add("NAMA_CUSTOMER");
            dtNasabah.Columns.Add("NO_CUSTOMER");
            dtNasabah.Columns.Add("ALAMAT");
            dtNasabah.Columns.Add("KODEPOS");
            dtNasabah.Columns.Add("HALAMAN");
        }

        #region layoutManagement
        int MouseX = 0, MouseY = 0;
        bool mouseDown;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                MouseX = MousePosition.X;
                MouseY = MousePosition.Y;

                this.SetDesktopLocation(MouseX, MouseY);
            }
        }
        #endregion

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.pdfOfd.ShowDialog();
            this.fileTextbox.Text = this.pdfOfd.FileName;
        }

        private void fileTextbox_Click(object sender, EventArgs e)
        {
            this.pdfOfd.ShowDialog();
            this.fileTextbox.Text = this.pdfOfd.FileName;
        }

        private void beginProcessBtn_Click(object sender, EventArgs e)
        {
            string filePath = this.fileTextbox.Text;
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            PdfReader pdfReader = new PdfReader(filePath);
            int pageSum = pdfReader.NumberOfPages;

            for (int x = 1; x <= pdfReader.NumberOfPages; x++)
            {
                dtNasabah.Rows.Add();
                dtNasabah.Rows[x - 1]["HALAMAN"] = x;

                ITextExtractionStrategy ITES = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy(); //simple read with accessible
                string textExctractor = PdfTextExtractor.GetTextFromPage(pdfReader, x, ITES);
                string[] rowData = textExctractor.Split('\n');

                int flagRow = 0;
                for (int j = 0; j < rowData.Length; j++)
                {
                    int noCust = 0;
                    if (rowData[j].Length > 6)
                        int.TryParse(rowData[j].Substring(0, 6), out noCust);

                    if (noCust != 0)
                    {
                        dtNasabah.Rows[x - 1]["NO_CUSTOMER"] = rowData[j].ToString();
                        dtNasabah.Rows[x - 1]["NAMA_CUSTOMER"] = rowData[j + 1].ToString();
                    }
                    else if (rowData[j].Contains("JL. "))
                    {
                        flagRow = j;
                    }
                    else if (rowData[j].Contains("Dengan hormat,"))
                    {
                        string mergedAddress = "";
                        for (int o = flagRow; o <= j - 2; o++)
                        {
                            if (!rowData[o].StartsWith("{") && !rowData[o].StartsWith("-"))
                                mergedAddress += (o < j - 2) ? rowData[o] + " " : rowData[o] + ".";
                        }
                        dtNasabah.Rows[x - 1]["ALAMAT"] = mergedAddress;
                        

                        string[] rowsdata = rowData[j - 1].ToString().Split(' ');
                        dtNasabah.Rows[x - 1]["KODEPOS"] = rowsdata[rowsdata.Count() - 1];
                    }
                }
            }

            exportToXls(dtNasabah);
            creatingPdf();
        }

        #region excel
        private void exportToXls(DataTable dtNasabah)
        {
            Workbook workbook = new Workbook();
            workbook.Worksheets.Clear();

            Styles styles = workbook.Styles;
            int styleIndex = styles.Add();
            Style styleHeader = styles[styleIndex];
            styleHeader.Font.Name = "Arial";
            styleHeader.Font.Size = 10;
            styleHeader.Font.IsBold = true;
            styleHeader.Pattern = BackgroundType.Solid;
            styleHeader.ForegroundColor = Color.FromArgb(0, 204, 255);
            styleHeader.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            styleHeader.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            styleHeader.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            styleHeader.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            styleIndex = styles.Add();
            Style styleData = styles[styleIndex];
            styleData.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            styleData.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            styleData.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            styleData.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            styleIndex = styles.Add();
            Style styleAngka = styles[styleIndex];
            styleAngka.HorizontalAlignment = TextAlignmentType.Center;
            styleAngka.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            styleAngka.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            styleAngka.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            styleAngka.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            styleIndex = styles.Add();
            Style stylePemisah = styles[styleIndex];
            stylePemisah.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            stylePemisah.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            stylePemisah.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            stylePemisah.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
            stylePemisah.Pattern = BackgroundType.Solid;
            stylePemisah.ForegroundColor = Color.Yellow;
            stylePemisah.Font.IsBold = true;

            Worksheet workSheet = workbook.Worksheets.Add("Hasil_Output");

            for (int i = 0; i < dtNasabah.Columns.Count; i++)
            {
                workSheet.Cells[0, i].PutValue(dtNasabah.Columns[i].ColumnName);
                workSheet.Cells[0, i].Style = styleHeader;
            }
            int k = 0;

            for (int i = 0; i < dtNasabah.Rows.Count; i++)
            {
                for (int j = 0; j < dtNasabah.Columns.Count; j++)
                {
                    if (j == 3 || j == 4)
                    {
                        workSheet.Cells[(i + 1), j].PutValue(dtNasabah.Rows[i][j].ToString());
                        workSheet.Cells[(i + 1), j].Style = styleAngka;
                    }
                    else
                    {
                        workSheet.Cells[(i + 1), j].PutValue(dtNasabah.Rows[i][j].ToString());
                        workSheet.Cells[(i + 1), j].Style = styleData;
                    }
                }
            }
            for (int x = 0; x < dtNasabah.Columns.Count; x++)
            {
                workSheet.AutoFitColumn(x);
            }

            workbook.Save("output.xls");
            MessageBox.Show("Excel file created successful.");
        }
        #endregion

        #region pdf
        protected void creatingPdf()
        {
            string outputPath = Directory.GetCurrentDirectory() + "\\output.pdf";
            string pdfPath = this.fileTextbox.Text;
            PdfReader reader = new PdfReader(pdfPath);

            var document = new Document(PageSize.A4);
            var stream = File.OpenWrite(outputPath);
            var writer = PdfWriter.GetInstance(document, stream);
            writer.PdfVersion = PdfWriter.VERSION_1_5;

            document.Open();
            PdfContentByte pb = writer.DirectContent;

            for(int a = 1; a <= reader.NumberOfPages; a++)
            {
                document.NewPage();
                PdfImportedPage page1 = writer.GetImportedPage(reader, a);
                pb.AddTemplate(page1, 0, 0);

                BarcodeQRCode qrcodeAtas = new BarcodeQRCode(DateTime.Now.ToString("yyyyMMdd") + a.ToString("D6"), 70, 70, null);
                iTextSharp.text.Image image1 = qrcodeAtas.GetImage();
                image1.ScaleAbsolute(35, 35);
                iTextSharp.text.Image mask1 = qrcodeAtas.GetImage();
                mask1.MakeMask();
                image1.ImageMask = mask1;
                image1.SetAbsolutePosition(109, 730);
                pb.AddImage(image1);
            }
            document.Close();

            MessageBox.Show("PDF file created successful.");
        }
        #endregion
    }
}

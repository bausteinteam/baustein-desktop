using baustein_desktop.Data.Repositories;
using baustein_desktop.Data.Services;
using Infragistics.Documents.Excel;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace baustein_desktop.App
{
    public partial class frmVak : Form
    {
        IVakRepo repo;
        public frmVak()
        {
            InitializeComponent();
            repo = new VakServ();
        }

        public void BindGrid()
        {
            var data = repo.GetAllVaks();
            ultraGridVak.DataSource = data;
        }

        private void frmVak_Load(object sender, EventArgs e)
        {
            BindGrid();
            gridInitialize();
        }

        private void gridInitialize()
        {
            UltraGridBand band = this.ultraGridVak.DisplayLayout.Bands[0];
            band.ColHeaderLines = 3;
            ultraGridVak.DisplayLayout.Bands[0].Columns[12].Format = "C";
            ultraGridVak.DisplayLayout.Bands[0].Columns[12].FormatInfo = new System.Globalization.CultureInfo("de-DE");
            ultraGridVak.DisplayLayout.Bands[0].Columns[12].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
            ultraGridVak.DisplayLayout.Bands[0].Columns[15].Format = "C";
            ultraGridVak.DisplayLayout.Bands[0].Columns[15].FormatInfo = new System.Globalization.CultureInfo("de-DE");
            ultraGridVak.DisplayLayout.Bands[0].Columns[15].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
            ultraGridVak.DisplayLayout.Bands[0].Columns[119].Format = "C";
            ultraGridVak.DisplayLayout.Bands[0].Columns[119].FormatInfo = new System.Globalization.CultureInfo("de-DE");
            ultraGridVak.DisplayLayout.Bands[0].Columns[119].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
            ultraGridVak.DisplayLayout.Bands[0].Columns[5].CellAppearance.BackColor = Color.Red;
            ultraGridVak.DisplayLayout.Bands[0].Columns[8].CellAppearance.BackColor = Color.Yellow;
            ultraGridVak.DisplayLayout.Bands[0].Columns[14].CellAppearance.BackColor = Color.Green;
            ultraGridVak.DisplayLayout.Bands[0].Columns[14].CellAppearance.ForeColor = Color.White;
            ultraGridVak.DisplayLayout.Bands[0].Columns[16].CellAppearance.BackColor = Color.Green;
            ultraGridVak.DisplayLayout.Bands[0].Columns[16].CellAppearance.ForeColor = Color.White;
            ultraGridVak.DisplayLayout.Bands[0].Columns[17].CellAppearance.BackColor = Color.Green;
            ultraGridVak.DisplayLayout.Bands[0].Columns[17].CellAppearance.ForeColor = Color.White;
            ultraGridVak.DisplayLayout.Bands[0].Columns[54].CellAppearance.BackColor = Color.Blue;
            ultraGridVak.DisplayLayout.Bands[0].Columns[54].CellAppearance.ForeColor = Color.White;
        }


        private void ultraGridVak_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            var id = this.ultraGridVak.Rows[e.Row.Index].Cells[0].Value.ToString();
            var answer = MessageBox.Show("Are you sure to Delete this Item?!", "Delete", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                var deleteVak = repo.GetVakById(int.Parse(id));
                repo.DeleteVak(deleteVak);
                BindGrid();
            }
        }

        private void btnAddVak_Click(object sender, EventArgs e)
        {
            frmNewVak frmnewvak = new frmNewVak();
            frmnewvak.ShowDialog();
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    UltraGridExcelExporter exporter = new UltraGridExcelExporter();

                    
                    exporter.Export(ultraGridVak, saveFileDialog.FileName);
                    var excelPackage = new OfficeOpenXml.ExcelPackage(new System.IO.FileInfo(saveFileDialog.FileName));
                    var worksheet = excelPackage.Workbook.Worksheets[0];

                    var germanCurrencyFormat = "#,##0.00 €";
                    var columnNumber = 13; 
                    var column = worksheet.Column(columnNumber);

                    
                    column.Style.Numberformat.Format = germanCurrencyFormat;

                    excelPackage.Save();

                    MessageBox.Show("Data exported to Excel successfully!");
                }
            }

        }
    }
}

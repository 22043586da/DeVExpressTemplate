using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Workbook workbook = new Workbook())
            {
                Worksheet worksheet = workbook.Worksheets[0];

                // Заполнение данных
                worksheet.Cells["A1"].Value = "Year";
                worksheet.Cells["B1"].Value = "Sales";
                worksheet.Cells["A2"].Value = 2016;
                worksheet.Cells["B2"].Value = 10000;
                worksheet.Cells["A3"].Value = 2017;
                worksheet.Cells["B3"].Value = 12000;
                worksheet.Cells["A4"].Value = 2018;
                worksheet.Cells["B4"].Value = 15000;

                // Добавление графика
                Chart chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet.Range["A1:B4"]);
                chart.Options.RoundedCorners = true;
                chart.TopLeftCell = worksheet.Cells["D1"];
                chart.BottomRightCell = worksheet.Cells["K10"];
                chart.Legend.Visible = false;
                chart.Title.SetValue("Sales Report");

                // Сохранение документа
                workbook.SaveDocument("SalesReport.xlsx", DocumentFormat.Xlsx);
            }
        }
    }
}

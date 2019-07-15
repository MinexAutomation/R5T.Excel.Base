using System;


namespace R5T.Excel.Base.Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.OpenExcelFile();
        }

        private static void OpenExcelFile()
        {
            var excelFilePath = @"C:\Temp\temp.xlsx";

            ExcelHelper.OpenInExcel(excelFilePath);
        }
    }
}

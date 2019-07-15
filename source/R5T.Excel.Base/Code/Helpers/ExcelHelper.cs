using System;
using System.Diagnostics;


namespace R5T.Excel
{
    public static class ExcelHelper
    {
        public const string DefaultExcelExecutableFilePath = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";


        public static void OpenInExcel(string excelFilePath, string excelExecutableFilePath = ExcelHelper.DefaultExcelExecutableFilePath)
        {
            var arguments = $@"""{excelFilePath}"""; // Surround in quotes.

            Process.Start(excelExecutableFilePath, arguments);
        }
    }
}

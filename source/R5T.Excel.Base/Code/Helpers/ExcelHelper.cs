using System;
using System.Diagnostics;


namespace R5T.Excel
{
    public static class ExcelHelper
    {
        public const string ExcelExecutableCommandValue = @"EXCEL.EXE";


        public static void OpenInExcel(string excelFilePath)
        {
            var arguments = $@"""{excelFilePath}"""; // Surround in quotes.

            Process.Start(ExcelHelper.ExcelExecutableCommandValue, arguments);
        }
    }
}

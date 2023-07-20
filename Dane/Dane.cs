using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace SanPlast.Dane
{
    static class Dane
    {
        public static DataSet DS { get; private set; }
        public static void ReadDS()
        {
            DS = new DataSet();
            DS.ReadXml(@"F:\SanPlast\Baza.xml");
        }

        public static void SaveDS()
        {
            DataSet DS1 = new DataSet();
            DS1.ReadXml(@"F:\SanPlast\Baza.xml");
            DataSet DS = new DataSet() { DataSetName = "Elementy" };
            var path = @"F:\SanPlast\Baza.xlsx";

            DS.Tables.Add(ExcelUtility.ExcelDataToDataTable(path, "Komponenty"));
            DS.Tables.Add(ExcelUtility.ExcelDataToDataTable(path, "Kabina"));
            DS.Tables.Add(ExcelUtility.ExcelDataToDataTable(path, "Set"));
            DS.WriteXml(@"F:\SanPlast\Baza.xml");
        }

        public class ExcelUtility
        {
            public static DataTable ExcelDataToDataTable(string filePath, string sheetName, bool hasHeader = true)
            {
                var dt = new DataTable() { TableName = sheetName };
                var fi = new FileInfo(filePath);
                // Check if the file exists
                if (!fi.Exists)
                    throw new Exception("File " + filePath + " Does Not Exists");

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var xlPackage = new ExcelPackage(fi);
                // get the first worksheet in the workbook
                var worksheet = xlPackage.Workbook.Worksheets[sheetName];
                var vr = xlPackage.Workbook.Worksheets;

                dt = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column].ToDataTable(c =>
                {
                    c.FirstRowIsColumnNames = true;
                });
                dt.TableName = sheetName;
                return dt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using OfficeOpenXml;


namespace SeleniumFramework.Utils
{
    public class ExcelHelper

    {
        public ExcelHelper()
        {
            string file = "/Thinscale.Challenging.DOM/DemoData.xlsx";

            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(file)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var sheet = package.Workbook.Worksheets["Data"]; // defining the sheet we are working from in excel

                var entries = new ExcelHelper().GetList<expectedData>(sheet);
            }
     
        }


        private List<T> GetList<T>(ExcelWorksheet sheet)
        {
            List<T> list = new List<T>();

            // first row is for knowing the properties of object
            var columnInfo = Enumerable.Range(1, sheet.Dimension.Columns).ToList().Select(n =>

                    new{Index=n, ColumnName=sheet.Cells[1,n].Value.ToString()}
                );

            for(int row=2; row<sheet.Dimension.Rows; row++)
            {
                T obj = (T)Activator.CreateInstance(typeof(T)); // generic object
                foreach(var prop in typeof(T).GetProperties())
                {
                    int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
                    var val = sheet.Cells[row, col].Value;
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(val, propType));


                }
                list.Add(obj);
            }

            return list;
           
        }

        // Data structure for the excel
        public class expectedData
        {
            public string expectedData1 { get; set; }
            public string expectedData2 { get; set; }
            public string expectedData3 { get; set; }
            public string expectedData4 { get; set; }
            public string expectedData5 { get; set; }
        }
    }
}

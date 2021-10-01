using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert J2C file into XLSX format.
    /// For more details about JPEG 2000 Image File (.j2c) to Microsoft Excel Open XML Spreadsheet (.xlsx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-j2c-to-xlsx
    /// </summary>
    internal static class ConvertJ2cToXlsx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "j2c-converted-to.xlsx");
            
            // Load the source J2C file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_J2C))
            {
                var options = new SpreadsheetConvertOptions();
                // Save converted XLSX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xlsx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

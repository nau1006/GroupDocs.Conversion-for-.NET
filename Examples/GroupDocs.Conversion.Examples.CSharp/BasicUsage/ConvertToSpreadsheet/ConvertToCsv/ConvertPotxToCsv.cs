using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert POTX file into CSV format.
    /// For more details about Microsoft PowerPoint Open XML Template (.potx) to Comma Separated Values File (.csv) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-potx-to-csv
    /// </summary>
    internal static class ConvertPotxToCsv
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "potx-converted-to.csv");
            
            // Load the source POTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_POTX))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Csv };
                // Save converted CSV file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to csv completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

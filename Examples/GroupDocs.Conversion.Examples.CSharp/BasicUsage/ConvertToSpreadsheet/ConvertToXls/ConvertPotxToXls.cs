using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert POTX file into XLS format.
    /// For more details about Microsoft PowerPoint Open XML Template (.potx) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-potx-to-xls
    /// </summary>
    internal static class ConvertPotxToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "potx-converted-to.xls");
            
            // Load the source POTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_POTX))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
                // Save converted XLS file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

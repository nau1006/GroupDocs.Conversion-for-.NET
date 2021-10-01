using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert JPEG file into XLS format.
    /// For more details about JPEG Image (.jpeg) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-jpeg-to-xls
    /// </summary>
    internal static class ConvertJpegToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "jpeg-converted-to.xls");
            
            // Load the source JPEG file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_JPEG))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
                // Save converted XLS file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

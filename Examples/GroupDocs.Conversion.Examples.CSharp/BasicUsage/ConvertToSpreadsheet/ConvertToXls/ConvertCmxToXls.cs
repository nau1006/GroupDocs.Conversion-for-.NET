using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert CMX file into XLS format.
    /// For more details about Corel Metafile Exchange Image File (.cmx) to Microsoft Excel Binary File Format (.xls) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-cmx-to-xls
    /// </summary>
    internal static class ConvertCmxToXls
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "cmx-converted-to.xls");
            
            // Load the source CMX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_CMX))
            {
                SpreadsheetConvertOptions options = new SpreadsheetConvertOptions { Format = GroupDocs.Conversion.FileTypes.SpreadsheetFileType.Xls };
                // Save converted XLS file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to xls completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

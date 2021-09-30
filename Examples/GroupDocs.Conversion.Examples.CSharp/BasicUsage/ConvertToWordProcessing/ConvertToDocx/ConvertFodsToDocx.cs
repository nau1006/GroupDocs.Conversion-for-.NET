using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert FODS file into DOCX format.
    /// For more details about OpenDocument Flat XML Spreadsheet (.fods) to Microsoft Word Open XML Document (.docx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-fods-to-docx
    /// </summary>
    internal static class ConvertFodsToDocx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "fods-converted-to.docx");
            
            // Load the source FODS file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_FODS))
            {
                var options = new WordProcessingConvertOptions();
                // Save converted DOCX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to docx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

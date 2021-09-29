using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert HTM file into DOC format.
    /// For more details about Hypertext Markup Language File (.htm) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-htm-to-doc
    /// </summary>
    internal static class ConvertHtmToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "htm-converted-to.doc");
            
            // Load the source HTM file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_HTM))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

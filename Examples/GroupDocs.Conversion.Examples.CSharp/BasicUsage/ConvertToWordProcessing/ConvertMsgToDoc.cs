using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MSG file into DOC format.
    /// For more details about Microsoft Outlook Email Format (.msg) to Microsoft Word Document (.doc) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-msg-to-doc
    /// </summary>
    internal static class ConvertMsgToDoc
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "msg-converted-to.doc");
            
            // Load the source MSG file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MSG))
            {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions();
                // Save converted DOC file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to doc completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

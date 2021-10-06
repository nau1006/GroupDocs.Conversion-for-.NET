using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSTX file into HTML format.
    /// For more details about Microsoft Visio File Format (.vstx) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vstx-to-html
    /// </summary>
    internal static class ConvertVstxToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vstx-converted-to.html");
            
            // Load the source VSTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSTX))
            {
                var options = new MarkupConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

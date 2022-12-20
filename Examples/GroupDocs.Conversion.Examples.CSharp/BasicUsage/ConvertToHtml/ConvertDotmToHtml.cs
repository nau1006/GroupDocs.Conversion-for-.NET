using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert DOTM file into HTML format.
    /// For more details about Microsoft Word Macro-Enabled Template (.dotm) to Hyper Text Markup Language (.html) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-dotm-to-html
    /// </summary>
    internal static class ConvertDotmToHtml
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "dotm-converted-to.html");
            
            // Load the source DOTM file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_DOTM))
            {
                var options = new WebConvertOptions();
                // Save converted HTML file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to html completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

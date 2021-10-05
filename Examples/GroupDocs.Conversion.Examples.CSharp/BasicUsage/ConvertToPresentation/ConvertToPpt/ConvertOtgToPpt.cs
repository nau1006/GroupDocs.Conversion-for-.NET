using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert OTG file into PPT format.
    /// For more details about OpenDocument Graphic Template (.otg) to PowerPoint Presentation (.ppt) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-otg-to-ppt
    /// </summary>
    internal static class ConvertOtgToPpt
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "otg-converted-to.ppt");
            
            // Load the source OTG file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_OTG))
            {
                PresentationConvertOptions options = new PresentationConvertOptions { Format = GroupDocs.Conversion.FileTypes.PresentationFileType.Ppt };
                // Save converted PPT file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to ppt completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

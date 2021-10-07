using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSTX file into TEX format.
    /// For more details about Microsoft Visio File Format (.vstx) to LaTeX Source Document (.tex) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vstx-to-tex
    /// </summary>
    internal static class ConvertVstxToTex
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vstx-converted-to.tex");
            
            // Load the source VSTX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSTX))
            {
                PdfConvertOptions options = new PdfConvertOptions { Format = GroupDocs.Conversion.FileTypes.PdfFileType.Tex };
                // Save converted TEX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to tex completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

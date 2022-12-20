using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert VSX file into SVG format.
    /// For more details about Vector Scalar Extension (.vsx) to Scalable Vector Graphics File (.svg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-vsx-to-svg
    /// </summary>
    internal static class ConvertVsxToSvg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "vsx-converted-to.svg");
            
            // Load the source VSX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_VSX))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Svg };
                // Save converted SVG file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to svg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

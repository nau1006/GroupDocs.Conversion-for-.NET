using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert MHTML file into JPG format.
    /// For more details about MIME Encapsulation of Aggregate HTML (.mhtml) to Joint Photographic Expert Group Image File (.jpg) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-mhtml-to-jpg
    /// </summary>
    internal static class ConvertMhtmlToJpg
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.jpg");
            Func<int, Stream> getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            // Load the source MHTML file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_MHTML))
            {
                // Set the convert options for JPG format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Jpg };  
                // Convert to JPG format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to jpg completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
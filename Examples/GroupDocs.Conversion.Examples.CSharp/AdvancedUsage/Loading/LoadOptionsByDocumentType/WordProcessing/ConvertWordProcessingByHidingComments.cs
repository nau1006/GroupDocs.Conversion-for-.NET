﻿using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a word-processing document to pdf with advanced options
    /// </summary>
    internal static class ConvertWordProcessingByHidingComments
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
            {
                HideComments = true
            };

            using (Converter converter = new Converter(Constants.SAMPLE_DOCX_WITH_TRACKED_CHANGES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nWordProcessing document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

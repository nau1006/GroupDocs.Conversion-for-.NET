﻿using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a presentation document to pdf with advanced options
    /// </summary>
    internal static class ConvertPresentationByHidingComments
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadOptions> getLoadOptions = () => new PresentationLoadOptions
            {
                HideComments = true
            };

            using (Converter converter = new Converter(Constants.PPTX_WITH_NOTES, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nPresentation document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

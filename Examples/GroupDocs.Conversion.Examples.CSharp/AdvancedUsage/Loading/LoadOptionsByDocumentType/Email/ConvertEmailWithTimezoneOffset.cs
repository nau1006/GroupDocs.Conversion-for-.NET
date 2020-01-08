﻿using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert an email document to pdf with advanced options
    /// </summary>
    internal static class ConvertEmailWithTimezoneOffset
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

#if NETCOREAPP
            Func<LoadOptions> getLoadOptions = () => new EmailLoadOptions
            {
                TimeZoneOffset = TimeSpan.FromHours(5)
            };
#else
            Contracts.Func<LoadOptions> getLoadOptions = () => new EmailLoadOptions
            {
                TimeZoneOffset = TimeSpan.FromHours(5)
            };
#endif
            using (Converter converter = new Converter(Constants.SAMPLE_EML, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nEmail document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

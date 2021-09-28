﻿using System;
using GroupDocs.Conversion.Examples.CSharp.AdvancedUsage;
using GroupDocs.Conversion.Examples.CSharp.BasicUsage;
using GroupDocs.Conversion.Examples.CSharp.QuickStart;

namespace GroupDocs.Conversion.Examples.CSharp
{
    internal static class RunExamples
    {
        static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            //NOTE: Please uncomment the example you want to try out

            #region Quick Start

            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();
            //HelloWorld.Run();

            #endregion

            #region Basic Usage

            // GetAllPossibleConversions.Run();
            // GetPossibleConversionsForSpecifiedDocumentExtension.Run();
            // GetPossibleConversions.Run();
            // GetSourceDocumentInfo.Run();

            #region Convert document to HTML

            // ConvertToHtml.Run();

            #endregion

            #region Convert document to Image

            // ConvertToJpg.Run();
            // ConvertToPng.Run();
            // ConvertToPsd.Run();

            #endregion

            #region Convert document to PDF


            // ConvertToPdf.Run();
            ConvertAiToPdf.Run();
            ConvertBmpToPdf.Run();
            //ConvertCdrToPdf.Run();
            ConvertCf2ToPdf.Run();
            ConvertCgmToPdf.Run();
            ConvertCmxToPdf.Run();
            ConvertCsvToPdf.Run();
            ConvertDgnToPdf.Run();
            ConvertDibToPdf.Run();
            ConvertDicomToPdf.Run();
            ConvertDjvuToPdf.Run();
            ConvertDngToPdf.Run();
            ConvertDocToPdf.Run();
            ConvertDocmToPdf.Run();
            ConvertDocxToPdf.Run();
            ConvertDotToPdf.Run();
            ConvertDotmToPdf.Run();
            ConvertDotxToPdf.Run();
            ConvertDwfToPdf.Run();
            ConvertDwfxToPdf.Run();
            ConvertDwgToPdf.Run();
            ConvertDwtToPdf.Run();
            ConvertDxfToPdf.Run();
            ConvertEmfToPdf.Run();
            ConvertEmlToPdf.Run();
            ConvertEmlxToPdf.Run();
            // ConvertEmzToPdf.Run();
            ConvertEpsToPdf.Run();
            ConvertEpubToPdf.Run();
            ConvertFodpToPdf.Run();
            ConvertFodsToPdf.Run();
            ConvertGifToPdf.Run();
            ConvertHtmToPdf.Run();
            ConvertHtmlToPdf.Run();
            ConvertIcoToPdf.Run();
            ConvertIfcToPdf.Run();
            ConvertIgsToPdf.Run();
            ConvertJ2cToPdf.Run();
            ConvertJ2kToPdf.Run();
            ConvertJlsToPdf.Run();
            ConvertJp2ToPdf.Run();
            ConvertJpcToPdf.Run();
            ConvertJpegToPdf.Run();
            ConvertJpfToPdf.Run();
            ConvertJpgToPdf.Run();
            ConvertJpmToPdf.Run();
            ConvertJpxToPdf.Run();
            ConvertLogToPdf.Run();
            ConvertMdToPdf.Run();
            //ConvertMboxToPdf.Run();
            ConvertMhtToPdf.Run();
            ConvertMhtmlToPdf.Run();
            ConvertMobiToPdf.Run();
            ConvertMppToPdf.Run();
            ConvertMptToPdf.Run();
            ConvertMpxToPdf.Run();
            ConvertMsgToPdf.Run();
            //ConvertOdgToPdf.Run();
            ConvertOdpToPdf.Run();
            ConvertOdsToPdf.Run();
            ConvertOdtToPdf.Run();
            ConvertOneToPdf.Run();
            //ConvertOstToPdf.Run();
            //ConvertOtgToPdf.Run();
            ConvertOtpToPdf.Run();
            ConvertOtsToPdf.Run();
            ConvertOttToPdf.Run();
            ConvertOxpsToPdf.Run();
            ConvertPclToPdf.Run();
            ConvertPltToPdf.Run();
            ConvertPngToPdf.Run();
            ConvertPsToPdf.Run();
            ConvertPotToPdf.Run();
            ConvertPotmToPdf.Run();
            ConvertPotxToPdf.Run();
            ConvertPpsToPdf.Run();
            ConvertPpsmToPdf.Run();
            ConvertPpsxToPdf.Run();
            ConvertPptToPdf.Run();
            ConvertPptmToPdf.Run();
            ConvertPptxToPdf.Run();
            ConvertPsdToPdf.Run();
            //ConvertPstToPdf.Run();
            ConvertRtfToPdf.Run();
            ConvertStlToPdf.Run();
            ConvertSvgToPdf.Run();
            //ConvertSvgzToPdf.Run();
            ConvertSxcToPdf.Run();
            ConvertTexToPdf.Run();
            ConvertTxtToPdf.Run();
            ConvertTifToPdf.Run();
            ConvertTiffToPdf.Run();
            ConvertTsvToPdf.Run();
            ConvertVcfToPdf.Run();
            ConvertVdwToPdf.Run();
            ConvertVdxToPdf.Run();
            ConvertVsdToPdf.Run();
            ConvertVsdmToPdf.Run();
            ConvertVsdxToPdf.Run();
            ConvertVssToPdf.Run();
            ConvertVssmToPdf.Run();
            ConvertVssxToPdf.Run();
            ConvertVstToPdf.Run();
            ConvertVstmToPdf.Run();
            ConvertVstxToPdf.Run();
            ConvertVsxToPdf.Run();
            ConvertVtxToPdf.Run();
            ConvertWebpToPdf.Run();
            ConvertWmfToPdf.Run();
            //ConvertWmzToPdf.Run();
            ConvertXlamToPdf.Run();
            ConvertXlsToPdf.Run();
            ConvertXlsbToPdf.Run();
            ConvertXlsmToPdf.Run();
            ConvertXlsxToPdf.Run();
            ConvertXltToPdf.Run();
            ConvertXltmToPdf.Run();
            ConvertXltxToPdf.Run();
            ConvertXmlToPdf.Run();
            ConvertXpsToPdf.Run();

            #endregion

            #region Convert document to Presentation

            // ConvertToPresentation.Run();

            #endregion

            #region Convert document to Spreadsheet

            // ConvertToSpreadsheet.Run();

            #endregion

            #region Convert document to WordProcessing

            // ConvertToWordProcessing.Run();

            #endregion

            #endregion

            #region Advanced Usage

            #region Common rendering options


            // AddWatermark.Run();
            // ConvertSpecificPages.Run();
            // GetDefaultConvertOptionsForDesiredTargetFormat.Run();
            // ConvertToStream.Run();

            #endregion

            #region Loading

            // GetDefaultLoadOptionsForSourceDocument.Run();
            // LoadPasswordProtectedDocument.Run();

            #region Loading documents from different sources

            // LoadDocumentFromLocalDisk.Run();
            // LoadDocumentFromStream.Run();
            // LoadDocumentFromUrl.Run();
            // LoadDocumentFromFtp.Run();

            #endregion

            #region Load options by document type

            #region Cad

            // ConvertCadAndSpecifyLayouts.Run();
            // ConvertCadAndSpecifyWidthAndHeight.Run();

            #endregion

            #region Csv

            // ConvertCsvByConvertingDateTimeAndNumericData.Run();
            // ConvertCsvBySpecifyingDelimiter.Run();
            // ConvertCsvBySpecifyingEncoding.Run();

            #endregion

            #region Email

            // ConvertEmailWithAlteringFieldsVisibility.Run();
            // ConvertEmailWithTimezoneOffset.Run();
            // ConvertEmailWithAttachments.Run();
            // ConvertEmailWithLocalizingEmailFields.Run();
            // ConvertEmailWithUseOfGlobalization.Run();

            #endregion

            #region Markup

            // ConvertMarkupWithAddingPageNumbering.Run();

            #endregion

            #region Note

            // ConvertNoteBySpecifyingFontSubstitution.Run();

            #endregion

            #region Pdf

            // ConvertPdfAndFlattenAllFields.Run();
            // ConvertPdfAndHideAnnotations.Run();
            // ConvertPdfAndRemoveEmbeddedFiles.Run();

            #endregion

            #region PersonalStorage

            // GetFoldersFromPersonalStorage.Run();
            // ConvertPersonalStorageContentToDifferentFormats.Run();

            #endregion

            #region Presentation

            // ConvertPresentationByHidingComments.Run();
            // ConvertPresentationBySpecifyingFontSubstitution.Run();
            // ConvertPresentationWithHiddenSlidesIncluded.Run();

            #endregion

            #region Spreadsheet

            // ConvertSpreadsheetAndHideComments.Run();
            // ConvertSpreadsheetByShowingGridLines.Run();
            // ConvertSpreadsheetBySkippingEmptyRowsAndColumns.Run();
            // ConvertSpreadsheetBySpecifyingFontSubstitution.Run();
            // ConvertSpreadsheetBySpecifyingRange.Run();
            // ConvertSpreadsheetWithHiddenSheetsIncluded.Run();

            #endregion

            #region Txt

            // ConvertTxtByControllingLeadingSpacesBehavior.Run();
            // ConvertTxtByControllingTrailingSpacesBehavior.Run(); 
            // ConvertTxtBySpecifyingEncoding.Run();

            #endregion

            #region WordProcessing

            // ConvertWordProcessingByHidingComments.Run();
            // ConvertWordProcessingByHidingTrackedChanges.Run();
            // ConvertWordProcessingBySpecifyingFontSubstitution.Run();

            #endregion

            #region Xml

            // ConvertXmlAsDataSourceToSpreadsheet.Run();

            #endregion

            #endregion

            #endregion

            #region Caching

            // UseCacheWhenProcessingDocuments.Run();

            #endregion

            // ConvertToHtmlWithAdvancedOptions.Run();
            // ConvertToImageWithAdvancedOptions.Run();
            // ConvertToPdfWithAdvancedOptions.Run();
            // ConvertToPresentationWithAdvancedOptions.Run();
            // ConvertToSpreadsheetWithAdvancedOptions.Run();
            // ConvertToWordProcessingWithAdvancedOptions.Run();

            // ConvertEachEmailAttachmentToDifferentFormat.Run();
            // ConvertOstDocumentMessagesToDifferentFormats.Run();

            // ConvertCsvToJson.Run();
            // ConvertCsvToXml.Run();
            // ConvertJsonAsDataSourceToSpreadsheet.Run();

            // ListenConversionStateAndProgress.Run();

            #endregion

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}

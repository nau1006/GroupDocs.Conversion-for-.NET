﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using GroupDocsConversionMVCDemoWithWatermark.Models;

namespace GroupDocsConversionMVCDemoWithWatermark.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index(ConvertModel model)
        {
            // your input file to be converted
            model.inputGUIDFile = "DOCXsample.docx";
            model.inputWatermarkText = "GroupDocs.Conversion - Watermark";
            return View(model);
        }


        public ViewResult ConvertCommand(string inputFile, string outputFileType)
        {
            {
                ConvertModel model = new ConvertModel();
                model.storagePath = Server.MapPath("~/App_Data/");
                model.cachePath = Server.MapPath("~/App_Data/output/");
                ConversionConfig conversionConfig = new ConversionConfig { StoragePath = model.storagePath, CachePath = model.cachePath };
                ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);

                // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
                //model.licensePath = Server.MapPath("~/App_Data/");
                //conversionHandler.SetLicense(model.licensePath);

                string outputFile = "converted\\SampleConverted." + outputFileType;

                string convertResult = "";

                try
                {
                    // Watermark Options object
                    WatermarkOptions watermarkOptions = new WatermarkOptions(model.inputWatermarkText);
                    watermarkOptions.Color = Color.Blue;
                    watermarkOptions.Font = new Font("Arial", 45);
                    watermarkOptions.RotationAngle = 65;
                    watermarkOptions.Transparency = 0.4;
                    watermarkOptions.Left = 20;
                    watermarkOptions.Top = 550;

                    if (outputFileType.ToLower().Equals("pdf"))
                    {
                        convertResult = conversionHandler.Convert<string>(inputFile, new PdfSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                    }
                    if (outputFileType.ToLower().Equals("xlsx"))
                    {
                        convertResult = conversionHandler.Convert<string>(inputFile, new CellsSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                    }
                    else if (outputFileType.ToLower().Equals("jpg"))
                    {
                        IList<string> convertResults = conversionHandler.Convert<IList<string>>(inputFile, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Jpg, OutputType = OutputType.String, WatermarkOptions = watermarkOptions });

                        // Conver to Image format returns multiple images path as string array, one image for each input document page.
                        foreach (string s in convertResults)
                        {
                            if (!s.Equals(""))
                            {
                                Download(s, outputFileType);
                            }
                        }
                        return null;
                    }
                    else if (outputFileType.ToLower().Equals("png"))
                    {
                        // Conver to Image format returns multiple images path as string array, one image for each input document page.
                        IList<string> convertResults = conversionHandler.Convert<IList<string>>(inputFile, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Png, OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                        foreach (string s in convertResults)
                        {
                            if (!s.Equals(""))
                            {
                                Download(s, outputFileType);
                            }
                        }
                        return null;
                    }
                    else if (outputFileType.ToLower().Equals("pptx"))
                    {
                        convertResult = conversionHandler.Convert<string>(inputFile, new SlidesSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                    }
                    else if (outputFileType.ToLower().Equals("html"))
                    {
                        convertResult = conversionHandler.Convert<string>(inputFile, new HtmlSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                    }


                    if (!convertResult.Equals(""))
                    {
                        Download(convertResult, outputFileType);
                    }
                }
                catch (Exception exc)
                {
                    convertResult = exc.Message;
                    TempData["ErrorMessage"] = convertResult;
                    return View("Error");
                }
            }
            return null;
        }
        private void Download(string outputFileName, string outputfileType)
        {
            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            var extension = Path.GetExtension(outputFileName);
            response.ContentType = outputfileType;
            response.AddHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(outputFileName) + ";");
            response.TransmitFile(outputFileName);
            response.Flush();
            response.End();
        }
    }
}

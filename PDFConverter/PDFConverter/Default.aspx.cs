using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using System.IO;

namespace DocumentConverter
{
    public partial class _Default : Page
    {

        private string storagePath = @"E:\aspose\"; // input files directory
        private string cachePath = @"E:\aspose\convertedFiles\";
        private string outputPath = @"E:\aspose\convertedFiles\";

        private string inputFile = string.Empty;//"PPTSample.pptx";        
        ConversionConfig conversionConfig = null;
        ConversionHandler conversionHandler = null;
        string convertedDocumentPath = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DirectoryInfo dinfo = new DirectoryInfo(storagePath);
                FileInfo[] Files = dinfo.GetFiles("*.*");
                foreach (FileInfo file in Files)
                {
                    lstSourceFiles.Items.Add(file.Name);
                }
            }
        }

        protected void btnConvertAll_Click(object sender, EventArgs e)
        {
            // string lblFilesConverted = string.Empty;
            if (lstSourceFiles.Items.Count > 0)
            {
                lblConvStatus.Text = "Conversion started. Please wait....";
                lblConvStatus.Visible = true;
                string outputfilename = string.Empty;
                foreach (ListItem lstItem in lstSourceFiles.Items)
                {
                    inputFile = lstItem.Text;
                    outputfilename = Path.GetFileNameWithoutExtension(inputFile) + ".pdf";
                    ListItem item = lstTargetFiles.Items.FindByValue(outputfilename);
                    if (item == null)
                    {
                        try
                        {
                            
                               //one way
                                conversionConfig = new ConversionConfig { OutputPath = outputPath, StoragePath = storagePath, CachePath = cachePath };
                                conversionHandler = new ConversionHandler(conversionConfig);
                                convertedDocumentPath =
                                   conversionHandler.Convert<string>(inputFile, new PdfSaveOptions { OutputType = OutputType.String });
                               
                            /* // another way
                            conversionConfig = new ConversionConfig()
                            {
                                OutputPath = outputPath,
                                CachePath = cachePath,
                                LocalesPath = cachePath,
                                StoragePath = storagePath,
                                UseCache = false
                            };


                            ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);
                            //check whether file suppoted
                            var availableConversions = conversionHandler.GetSaveOptions(Path.GetExtension(inputFile).Replace(".", ""));
                            PdfSaveOptions saveOptions = new PdfSaveOptions()
                            {
                                ConvertFileType = PdfSaveOptions.PdfFileType.Pdf,
                                PageNumber = 1,
                                NumPagesToConvert = 1,
                                CustomName = Path.GetFileNameWithoutExtension(inputFile),
                                OutputType = OutputType.String
                            };
                            var memStream = new MemoryStream(File.ReadAllBytes(storagePath + "" + inputFile));
                            convertedDocumentPath = conversionHandler.Convert<String>(memStream, saveOptions);
                            */
                            lstTargetFiles.Items.Add(outputfilename);
                           
                        }
                        catch (Exception ex)
                        {
                            lblWrongFormat.Text = inputFile + " issue - " + ex.Message;
                            lblWrongFormat.Visible = true;
                        }

                    }
                    else
                    {
                        lblConvStatus.Text = inputFile + " file already converted.";
                    }
                }
                lblConvStatus.Text = "Conversion completed.";
            }
        }

       
    }
}
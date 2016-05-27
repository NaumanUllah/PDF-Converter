# PDF-Converter
Convert documents of different formats including images to PDF using GroupDocs.Conversion .NET PDF Library. Step for converting any of following file formats to PDF using  GroupDocs.Conversion C# PDF library with asp.net web forms

# System Requirements
.Net Framework 4.5
Visual Studio 12, VS 13

# Solution Overview
1.	Download as a zip from https://github.com/NaumanUllah/PDF-Converter
 
2.	Unzip file and open PDFConverter folder you will get solution file to run the project in your visual studio installed. So double click on PDFConverter.sln file
3.	When solution is ready in visual studio. Right click on solution and click on Bulid or Rebuild Solution. Nuget Package Manager will appear. It will take bit time for downloading required nugget packages.
 
4.	After successful build – expand Default.aspx file and double click on Default.aspx.cs file to set the path of your source and target directories. 
  

5.	Change the following path in Default.aspx.cs file according to your own 

        private string storagePath = @"E:\aspose\"; 

        private string cachePath = @"E:\aspose\convertedFiles\";

        private string outputPath = @"E:\aspose\convertedFiles\";

6.	Run project . It will automatically load all files from your directory path you adjusted and will appear like
 

7.	Press convert button to transform files to PDF and bit wait. Files converted will appear in Target files section. Last file not converted error appear at top. Read more detail on its wiki

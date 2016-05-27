# PDF Converter
Convert documents of different formats including images to PDF using GroupDocs.Conversion .NET PDF Library. Step for converting any of supported file formats to PDF using  GroupDocs.Conversion C# PDF library with asp.net web forms

# System Requirements

.Net Framework 4.5
Visual Studio 12 
Visual Studio 13

# Solution Overview
1.	Download as a zip from https://github.com/NaumanUllah/PDF-Converter

![promisechains](https://cloud.githubusercontent.com/assets/19569320/15599077/f75091ee-23f9-11e6-9489-d09b6f7b4b40.png)
 
2.	Unzip file and open PDFConverter folder you will get solution file to run the project in your visual studio installed. So double click on PDFConverter.sln file

3.	When solution is ready in visual studio. Right click on solution and click on Bulid or Rebuild Solution. Nuget Package Manager will appear. It will take bit time for downloading required nugget packages.
	

![promisechains](https://cloud.githubusercontent.com/assets/19569320/15599079/f7841de8-23f9-11e6-8376-9229e6c96dca.png)
 
4.	After successful build – expand Default.aspx file and double click on Default.aspx.cs file to set the path of your source and target directories. 
  
![promisechains](https://cloud.githubusercontent.com/assets/19569320/15599076/f71fb09c-23f9-11e6-8971-73849f00c94e.png)

5.	Change the following path in Default.aspx.cs file according to your own 

        private string storagePath = @"E:\aspose\"; 

        private string cachePath = @"E:\aspose\convertedFiles\";

        private string outputPath = @"E:\aspose\convertedFiles\";

6.	Run project . It will automatically load all files from your directory path you adjusted and will appear like
 

![promisechains](https://cloud.githubusercontent.com/assets/19569320/15599078/f755351e-23f9-11e6-9de8-e6ca14d7871a.png)

7.	Press convert button to transform files to PDF and bit wait. Files converted will appear in Target files section. Last file not converted error appear at top. 

![promisechains](https://cloud.githubusercontent.com/assets/19569320/15599080/f7f39696-23f9-11e6-8581-8874b59a260d.png)


Read more detail on its wiki

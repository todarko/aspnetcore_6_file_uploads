# Uploading files in ASP.NET 6 Core Web App using Razor Pages

### Pages/Upload/SingleInput.cshtml/.cs

This page creates a list of IFormFile objects that get sent to the model controller for processing. The var max in the .cshtml file sets how many can be uploaded. Each file is dynamically added to the page, it can also be removed from the list of files to be uploaded. 

### Pages/Upload/MultipleInput.cshtml/cs
This creates a static number of inputs for each file. There is a single upload file button. Each file uploaded is set to the input as well as showing a thumbnail of the image. 

## Back end processing is not set up, check here for processing the IFormFile to a file storage or save to a DB. [MS Docs on Uploads](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-6.0)

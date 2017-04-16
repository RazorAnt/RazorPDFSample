RazorPDFSample
==============

This is a very basic sample project showing you how to use RazorPDF to build PDF files.

## Overview
It is an ASP.NET MVC3 project with the default template in.  The additions are pretty minor.

* Used Nuget to add RazorPDF to project
* Added a Person class (for a sample model)
* Added a few links to the Home/Index page.
* A few changes to the HomeController to support those links.

Run the project, look at the links, then look at the home controller and the related views to see how it all works.

## About
RazorPDF uses the Razor View Engine to create iTextXML which in turn is used to produce the PDF files.  RazorPDF is basically a port of the PDF feature of Spark View Engine.

More details on this can be found on [my blog](http://nyveldt.com/blog/page/razorpdf).
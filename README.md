# URLAnalyzer
Challenge project to show Images and Word Counts for a given URL

## Setup Instructions
1.  Clone this repository to your local computer.  This can be done graphically from the github.com website, or from the command prompt:
    1. Create a directory under your C:\Users\<youruser> for the solution, and change to that directory:
        ```
          mkdir URLAnalyzer
          chdir URLAnalyzer
        ```
    3. clone the repository to your local drive
        ```
          git clone https://github.com/scotthwylie/URLAnalyzer.git
        ```
  
2.  Using Visual Studio 2017, load the **URLAnalyzer.sln** solution
3.  Hit F5 or the IIS Express button in Visual Studio to launch the website

## Run Instructions
1. Enter a URL in the URL field
2. Click on the **Submit** button
3. If the input URL points to a valid website, you should be presented with a screen showing a carousel of the Images of that website, a total word count, and a graph of the top 10 words in that website.
4. If the input URL does not point to a valid website, an error will be shown.

## Technical Documentation
This project was written using ASP.NET MVC Core, and Razor views for the front end.  The Models and Controller Actions are very simple, allowing the dependecy injected URLAnalyzerService to do the heavy lifting on the back end.

The back end URLAnalyzerService currently uses WebClient synchronously to load the web page contents, and parse it for images and words.  A future enhancement might be to use HttpClient instead, and to change the service and controller to be async.

The URL input is validated by the model attributes [required] and [url] to ensure proper data entry format.  A custom ValidationAttribute [CustomUrlValidator] was added to make sure the URL entered is a valid website.

#pragma checksum "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3b8f37d5fcda633a470b2cf4a968cdc56334cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoadUrl), @"mvc.1.0.view", @"/Views/Home/LoadUrl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LoadUrl.cshtml", typeof(AspNetCore.Views_Home_LoadUrl))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\_ViewImports.cshtml"
using URLAnalyzer;

#line default
#line hidden
#line 2 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\_ViewImports.cshtml"
using URLAnalyzer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3b8f37d5fcda633a470b2cf4a968cdc56334cf", @"/Views/Home/LoadUrl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea937c036e972dc03ef27883b247a9742b4e341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoadUrl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoadUrlModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
  
    ViewData["Title"] = "LoadUrl";

#line default
#line hidden
            BeginContext(66, 818, true);
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

<div class=""container"">
    <div class=""card-deck row"">
        <div class=""card text-center col-lg-9"">
            <div class=""card-body"">
                <h3 class=""card-header"">Images: <span id=""imgCount"">1</span> of ");
            EndContext();
            BeginContext(885, 23, false);
#line 15 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                                                                           Write(Model.ImageList.Count());

#line default
#line hidden
            EndContext();
            BeginContext(908, 506, true);
            WriteLiteral(@"</h3>
                <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""3000"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner text-center"">
");
            EndContext();
#line 23 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                          
                            var imageNdx = 0;
                            foreach (var image in @Model.ImageList)
                            {
                                var divClass = imageNdx++ == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
            BeginContext(1697, 36, true);
            WriteLiteral("                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1733, "\"", 1750, 1);
#line 28 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
WriteAttributeValue("", 1741, divClass, 1741, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 43, true);
            WriteLiteral(">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1794, "\"", 1806, 1);
#line 29 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
WriteAttributeValue("", 1800, image, 1800, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1807, 68, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                                </div>\r\n");
            EndContext();
#line 31 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1933, 1018, true);
            WriteLiteral(@"                    </div>
                    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
        <div class=""card text-center col-lg-3"">
            <div class=""card-body"">
                <h3 class=""card-header"">Total Word Count</h3>
                <div class=""justify-content-center d-flex"" style=""height: 300px;"">
                    <h2 class=""justify-content-center align-self-center card-theme"" >
                        ");
            EndContext();
            BeginContext(2952, 15, false);
#line 50 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                   Write(Model.WordCount);

#line default
#line hidden
            EndContext();
            BeginContext(2967, 399, true);
            WriteLiteral(@"
                    </h2>
                </div>
            </div>
        </div>

    </div>
    <div class=""card-deck row"">
        <div class=""card text-center col-lg-12"">
            <div class=""card-body"">
                <h3 class=""card-header"">10 Most Frequent Words</h3>
                <div id=""top10chart""></div>
            </div>
        </div>
    </div>
</div>



");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3383, 1097, true);
                WriteLiteral(@"
    <script>
        // Set the image counter for display of ""Images: x of y"".
        $(document).ready(function(){
            $(""#myCarousel"").on('slid.bs.carousel', function(){
                var currentIndex = $(""div.active"").index() + 1;
                if (currentIndex == 22) {
                    currentIndex = 1;
                }
                $(""#imgCount"").text(currentIndex);
            });
        });
    </script>

    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script>
        // Use google charts for a column chart of 10 most frequent words
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            // Column Chart with Data Array:
            let top10array = [];
            top10array.push(['Word', 'Count', { role: 'style' }]);
            let barColors = ['#3F69AA', '#D5AE41'];

            // Grab first 10 ");
                WriteLiteral("elements from the Model\'s WordCounts property, and push onto the array.\r\n");
                EndContext();
#line 96 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
             for (int ndx=0; ndx < 10 && ndx < Model.WordCounts.Count(); ndx++) 
            {
                var element = Model.WordCounts.ElementAt(ndx);

#line default
#line hidden
                BeginContext(4641, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(4659, 18, true);
                WriteLiteral("top10array.push([\"");
                EndContext();
                BeginContext(4678, 11, false);
#line 99 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                               Write(element.Key);

#line default
#line hidden
                EndContext();
                BeginContext(4689, 13, true);
                WriteLiteral("\", parseInt(\"");
                EndContext();
                BeginContext(4703, 13, false);
#line 99 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                                                        Write(element.Value);

#line default
#line hidden
                EndContext();
                BeginContext(4716, 18, true);
                WriteLiteral("\", 10), barColors[");
                EndContext();
                BeginContext(4735, 3, false);
#line 99 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
                                                                                        Write(ndx);

#line default
#line hidden
                EndContext();
                BeginContext(4738, 9, true);
                WriteLiteral(" %2]]);\r\n");
                EndContext();
#line 100 "C:\Users\scott\source\repos\URLAnalyzer.CloneTest\URLAnalyzer\URLAnalyzer\Views\Home\LoadUrl.cshtml"
            }

#line default
#line hidden
                BeginContext(4762, 582, true);
                WriteLiteral(@"            var data = google.visualization.arrayToDataTable(top10array, false);
            var option = {
                title: '', // don't want the title, our card will have the header
                chartArea: {'width': '90%', 'height': '80%'},
                //width: 800,
                height: 300
            };
            var chart = new google.visualization.ColumnChart(document.getElementById('top10chart'));
            chart.draw(data, option);
        }

        $(window).resize(function(){
            drawChart();
        });
    </script>
    ");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoadUrlModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

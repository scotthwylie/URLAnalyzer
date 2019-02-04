using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using URLAnalyzer.Models;

namespace URLAnalyzer.Services
{
    public class URLAnalyzerService: IURLAnalyzerService
    {
        #region Private fields
        private HtmlDocument document;
        private WebClient client = new WebClient();
        #endregion

        public LoadUrlModel GetUrlModel(string url)
        {
            LoadUrlModel model = new LoadUrlModel();
            document = CacheDocument(url);
            model.ImageList = GetAllImages(url);
            CountWords(model);

            return model;
        }


        #region private methods
        private HtmlDocument CacheDocument(string url)
        {
            HtmlDocument localDocument = new HtmlDocument();
            try
            {
                string source = client.DownloadString(url);
                localDocument.LoadHtml(source);
            }
            catch
            {
                return null;
            }

            return localDocument;
        }

        private void CountWords(LoadUrlModel model)
        {
            var nodes = document.DocumentNode.SelectNodes("//text()");
            var nodes2 = from t in document.DocumentNode.Descendants("//text()") select t.InnerText;
            foreach (HtmlNode node in nodes)
            {
                string s = node.InnerText;
                if (!string.IsNullOrWhiteSpace(s) && s.Length > 0)
                {
                    s = s.ToLower();
                    string[] words = s.Split(" ");
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrWhiteSpace(word) && IsAlphaNum(word))
                        {
                            if (model.WordCounts.ContainsKey(word))
                            {
                                model.WordCounts[word]++;
                            }
                            else
                            {
                                model.WordCounts.Add(word, 1);
                            }
                            model.WordCount++;
                        }
                    }
                }
            }
            // Sort by count, descending
            model.WordCounts = model.WordCounts.OrderByDescending(d => d.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private bool IsAlphaNum(string s)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9][a-zA-Z0-9]*$");
            return rg.IsMatch(s);
        }

        private List<string> GetAllImages(string url)
        {
            List<string> list = new List<string>();
            // For every tag in the HTML containing the node img.
            foreach (HtmlAttribute link in document.DocumentNode.Descendants("img")
                                        .Select(i => i.Attributes["src"]))
            {
                if (link != null && !string.IsNullOrEmpty(link.Value))
                {
                    string src = link.Value;
                    // if img src is not absolute, combine base uri with src:
                    if (!src.StartsWith("//"))
                    {
                        Uri baseUrl = new Uri(url);
                        Uri finalUrl = new Uri(baseUrl, src);
                        //if (!finalUrl.Host.StartsWith("www."))
                        //{
                        //    UriBuilder builder = new UriBuilder(finalUrl);
                        //    builder.Host = "www." + finalUrl.Host;
                        //    finalUrl = builder.Uri;
                        //}
                        src = finalUrl.ToString();
                    }
                    if (!list.Contains(src))
                    {
                        list.Add(src);
                    }
                }
            }
            return list;
        }
        #endregion
    }
}

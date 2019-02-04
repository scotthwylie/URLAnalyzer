using System.Collections.Generic;

namespace URLAnalyzer.Models
{
    public class LoadUrlModel
    {
        #region Model Properties
        public List<string> ImageList { get; set; } = new List<string>();
        public Dictionary<string, int> WordCounts { get; set; } = new Dictionary<string, int>();
        public int WordCount { get; set; } = 0;
        #endregion
    }
}

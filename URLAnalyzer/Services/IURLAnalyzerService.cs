using URLAnalyzer.Models;

namespace URLAnalyzer.Services
{
    public interface IURLAnalyzerService
    {
        LoadUrlModel GetUrlModel(string url);
    }
}

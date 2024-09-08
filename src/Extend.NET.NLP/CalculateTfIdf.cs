namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates the TF-IDF (Term Frequency-Inverse Document Frequency) score for a term in a document.
    /// </summary>
    /// <param name="term">The term to calculate the TF-IDF score for.</param>
    /// <param name="document">The document containing the term.</param>
    /// <param name="allDocuments">All documents in the corpus.</param>
    /// <returns>The TF-IDF score for the term in the document.</returns>
    public static double CalculateTfIdf(this string term, string document, IEnumerable<string> allDocuments)
    {
        double tf = document.Split().Count(w => w.Equals(term, StringComparison.OrdinalIgnoreCase)) / (double)document.Split().Length;
        double idf = Math.Log(allDocuments.Count() / (double)(1 + allDocuments.Count(doc => doc.Contains(term, StringComparison.OrdinalIgnoreCase))));
        return tf * idf;
    }
}
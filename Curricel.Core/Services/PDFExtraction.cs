namespace Curricel.Core.Services;
using System;
using UglyToad.PdfPig;

public class PDFExtraction
{
    using (PdfDocument document = UglyToad.PdfPig.PdfDocument.Open(@"C:\Users\iCan Student\Downloads\camera shots.pdf"))
    {
        foreach (Page page in document.GetPages())
        {
            IReadOnlyList<Letter> letters = page.GetWords();

            IEnumerable<Word> words = page.GetWords();

            IEnumerable<IPdfImage> images = page.GetImages();
        }
    }
}
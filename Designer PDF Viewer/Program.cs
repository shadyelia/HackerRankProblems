using System;

namespace Designer_PDF_Viewer
{
    class Program
    {
        //a->97
        static int designerPdfViewer(int[] h, string word) { 
            int maxHeight = 0;
            foreach(var chata in word){
                if(maxHeight < h[chata-97]) maxHeight = h[chata-97];
            }
            return maxHeight*word.Length;
           }

    static void Main(string[] args) {

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        Console.WriteLine(result);

    }
    }
}

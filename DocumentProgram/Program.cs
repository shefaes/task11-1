using System;

namespace DocumentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "basic";

            if (word=="basic")
            {
                DocumentProgram basic = new DocumentProgram();
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
            }
            else if (word=="pro")
            {
                ProDocumentProgram pro = new ProDocumentProgram();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else
            {
                ExpertDocumentProgram expert = new ExpertDocumentProgram();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }

           



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote_Note_Library
{
    public class ArticleModel
    {
        string Article_ID;
        public string article_ID { get => Article_ID; set => Article_ID = value; }

        private string ArticleName;
        public string articleName { get => ArticleName; set => ArticleName = value; }

        private string AuthorName; 
        public string authorName { get => AuthorName; set => AuthorName = value; }

        private string PageNumber;
        public string pageNumber { get => PageNumber; set => PageNumber = value; }

        private JournalModel ArticleJournal;     
        public JournalModel articleJournal { get => ArticleJournal; set => ArticleJournal = value; }
    }
}

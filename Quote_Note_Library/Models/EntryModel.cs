using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote_Note_Library
{
    public class EntryModel
    {
        uint Entry_ID;
        public uint entry_ID { get => Entry_ID; set => Entry_ID = value; }

        string EntryTitle;
        public string entryTitle { get => EntryTitle; set => EntryTitle = value; }
        
        string EntryContent;
        public string entryContent { get => EntryContent; set => EntryContent = value; }

        bool IsQuote;
        public bool isQuote { get => IsQuote; set => IsQuote = value; }

        ArticleModel EntryArticle;
        public ArticleModel entryArticle { get => EntryArticle; set => EntryArticle = value; }
    }
}

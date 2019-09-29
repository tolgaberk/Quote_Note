using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote_Note_Library
{
    public class JournalModel
    {
        uint Journal_ID;
        public uint journal_ID { get => Journal_ID; set => Journal_ID = value; }

        string JournalName;
        public string journalName { get => JournalName; set => JournalName = value; }

        string JournalIssue;
        public string journalIssue { get => JournalIssue; set => JournalIssue = value; }

        string JournalVolume;
        public string journalVolume { get => JournalVolume; set => JournalVolume = value; }

        string JournalYear;
        public string journalYear { get => JournalYear; set => JournalYear = value; }

       
    }
}

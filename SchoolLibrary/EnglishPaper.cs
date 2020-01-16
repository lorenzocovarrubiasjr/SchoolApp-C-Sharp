using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class EnglishPaper : IScored
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}

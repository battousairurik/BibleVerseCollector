using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BibleVerseCollector.Models
{
    public class BibleVerse
    {
        [Key]
        public int BibleVerseID { get; set; }

        [Required]
        public bool NewTestament { get; set; }

        [Required]
        public String BookTitle { get; set; }

        [Required]
        public int ChapterNumber { get; set; }

        [Required]
        public int VerseNumber { get; set; }

        [Required]
        public String VerseText { get; set; }
        
    }
}
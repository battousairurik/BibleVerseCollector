using BibleVerseCollector.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BibleVerseCollector.Context
{
    public class BibleVerseContext : DbContext
    {
        public virtual DbSet<BibleVerse> BibleVerse { get; set; }

    }
}
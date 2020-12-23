using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibor
{
    public class BookmarkFolder
    {
        public List<BookmarkFolder> Subfolders { get; set; }
        public List<Bookmark> Bookmarks { get; set; }
    }
}

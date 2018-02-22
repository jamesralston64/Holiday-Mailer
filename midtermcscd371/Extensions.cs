using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermcscd371
{
    class Extensions
    {
        private static string[] _fileExtensions = { "AVI", "JAVA", "CSV","DOC", "DOCX", "EXE","GIF", "HTML", "JPG", "JPEG", "PDF",
            "PNG", "PPT", "PPTX", "RTF", "TXT", "XLS", "XLSX", "ZIP" };

        public static string[] FileExtensions
        {
            get
            {
                return _fileExtensions;
            }
        }
    }
}

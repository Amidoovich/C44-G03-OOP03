using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    internal class EBook : Book
    {
        public float FileSize { get; set; }


        public EBook(string title, string author, int isbn , float fileSize) : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"File Size : {FileSize}";
        }
    }
}

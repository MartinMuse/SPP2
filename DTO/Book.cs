using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator;

namespace DTO
{
    public class Book : IDTO
    {
        public double progress;
        public List<Book> similar { get; set; }
        public Uri resource { get; }
        private string name;
        private int pageCount;
        public Publisher Publisher { get; set; }

        public Book(string name, int pageCount, Uri resource)
        {
            this.name = name;
            this.pageCount = pageCount;
            this.resource = resource;
        }

        public override string ToString()
        {
            StringBuilder similarBooks = new StringBuilder();
            if (similar.Count > 0)
            {
                similarBooks.Append("\nSimilar books:");


                foreach (var book in this.similar)
                {
                    if (book != null)
                    {
                        similarBooks.Append("\n" + book.ToString());
                    }
                }

                similarBooks.Replace("\n", "\n   ");
            }

            StringBuilder publisher = new StringBuilder();
            if (this.Publisher != null)
            {
                publisher.Append(String.Format("\nPublisher: {0}", Publisher.name));
            }

            return String.Format("Book (name=\"{0}\", pageCount=\"{1}\", progress=\"{2}\", resource=\"{3}\"){4}{5}\n", name, pageCount,
                            progress, resource, publisher, similarBooks);
        }
    }
}

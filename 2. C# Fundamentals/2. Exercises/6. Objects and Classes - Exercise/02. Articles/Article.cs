using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

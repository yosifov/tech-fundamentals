namespace TechFundamentals.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        private void Edit(string content)
        {
            this.Content = content;
        }

        private void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        private void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return Title + " - " + Content + ": " + Author;
        }

        public static void Execute()
        {
            var articleData = Console.ReadLine().Split(", ");

            var articleTitle = articleData[0];
            var articleContent = articleData[1];
            var articleAuthor = articleData[2];

            var article = new Articles(articleTitle, articleContent, articleAuthor);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                var input = Console.ReadLine().Split(": ");
                string command = input[0];
                string inputText = input[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(inputText);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(inputText);
                        break;
                    case "Rename":
                        article.Rename(inputText);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }

        public static void Store()
        {
            int sumArticles = int.Parse(Console.ReadLine());
            List<Articles> articles = new List<Articles>(sumArticles);
            for (int i = 0; i < sumArticles; i++)
            {
                var articleData = Console.ReadLine().Split(", ");

                articles.Add(new Articles(articleData[0], articleData[1], articleData[2]));
                //articles[i].Title = articleData[0];
                //articles[i].Content = articleData[1];
                //articles[i].Author = articleData[2];
            }
            var command = Console.ReadLine();
            var orderedArticles = new List<Articles>();
            switch (command)
            {
                case "title":
                    orderedArticles = articles.OrderBy(o => o.Title).ToList();
                    break;
                case "content":
                    orderedArticles = articles.OrderBy(o => o.Content).ToList();
                    break;
                case "author":
                    orderedArticles = articles.OrderBy(o => o.Author).ToList();
                    break;
                default:
                    break;
            }
            foreach (var article in orderedArticles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}

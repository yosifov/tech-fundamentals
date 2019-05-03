namespace TechFundamentals.Classes
{
    using System;

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
                string input = Console.ReadLine();
                
                switch (input.Split()[0])
                {
                    case "Edit:":
                        article.Edit(input.Substring(6));
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(input.Substring(14));
                        break;
                    case "Rename:":
                        article.Rename(input.Substring(8));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}

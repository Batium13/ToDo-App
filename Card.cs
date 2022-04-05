namespace ToDo_App
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; } 
        public int Size { get; set; }

        public Card(string title,string content,int userId,int size)
        {
           Title=title;
           Content=content;
           UserID=userId;
           Size=size;
        }
    }
}
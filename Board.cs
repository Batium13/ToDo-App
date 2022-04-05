using System.Collections.Generic;

namespace ToDo_App
{
    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            TODO.Add(new Card("Okuma", "Yatmadan önce kitap okumayı unutma!", 1, 1));
            IN_PROGRESS.Add(new Card("Patika Proje2", "ToDo app projesini tamamla.", 2, 3));
            DONE.Add(new Card("Programlama", "Program yazmadan veya ilgili bir iş yapmadan gününü geçirme!", 3, 4));
        }

        public List<Card> GetProperty(string str)
        {
            if (str == "TODO")
                return this.TODO;
            else if (str == "IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }

    }
}
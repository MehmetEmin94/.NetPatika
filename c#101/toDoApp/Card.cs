using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    public class Card
    {
        private string header;
        private string content;
        private int personId;
        private Size size;

        public Card() { }

        public Card(string Header, string Content, int PersonId, Size Sz)
        {
            header = Header;
            content = Content;
            personId = PersonId;
            size = Sz;
        }

        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }
        public int PersonId { get => personId; set => personId = value; }
        public Size Sz { get => size; set => size = value; }
    }
}

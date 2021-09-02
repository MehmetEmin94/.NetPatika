using System;
namespace todo_app
{
    public class Card{
        private string header;
        private string content;
        private int personId;
        private Size size;

        public Card(){}
        public Card(string Header,string Content,int Id){
            this.header=Header;
            this.content=Content;
            this.personId=Id;
        }

    }
}
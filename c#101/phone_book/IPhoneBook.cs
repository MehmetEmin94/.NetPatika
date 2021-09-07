namespace phone_book
{
    public interface IPhoneBookService{
        void save();
        void delete();
        void update();
        void list();
        void search();
    }
}
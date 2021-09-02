namespace interfaces_
{
    public class Civic : ICar
    {
        public Color StandartColor()
        {
            return Color.Grey;
        }

        public int WheelNum()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Honda;
        }
    }
}
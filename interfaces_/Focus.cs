namespace interfaces_
{
    public class Focus : ICar
    {
        public Color StandartColor()
        {
            return Color.White;
        }

        public int WheelNum()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Ford;
        }
    }
}

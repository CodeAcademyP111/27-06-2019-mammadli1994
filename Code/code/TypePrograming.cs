namespace CodeAcademya
{
    public class TypePrograming
    {
        private static int ID;
        public int Price { get; set; }

        public TypePrograming(int price)
        {
            ID++;
            Price = price;
        }
    }
}
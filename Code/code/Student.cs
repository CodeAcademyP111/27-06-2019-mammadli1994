namespace CodeAcademya
{
    internal class Student
    {
        private static int ID;

        public string Name { get; set; }
        public string Surname { get; set; }
        private int _money;
        public int Money {
            get
            {
                return _money;
            }
            set
            {
                if (value == 3500)
                {
                    _money = value;
                }
            }
                }

       
    

        public TypePrograming Price { get; set; }

        public Student(string name, string surname, int money,TypePrograming price)
        {
            ID++;
            Name = name;
            Surname = surname;
            Money = money;
            Price = price;
        }

        public int GetPrice(int _money)
        {
            if (Money >= 3500)
            {
                return Money;
            }
            else
            {
                return _money;
            }
        }
    }
}
namespace SRAJENCSHARPPOC{
    class Human{
        public void Breath(){
            Console.WriteLine("Human Breathes....");
        }
    }
    class Male: Human{
        public void Brain(){
            Console.WriteLine("Human is having brain");
        }
    }
    class Female: Male{
        public void Heart(){
            Console.WriteLine("Human is having heart");
        }
    }
}
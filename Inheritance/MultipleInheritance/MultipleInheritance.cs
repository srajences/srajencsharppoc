namespace SRAJENCSHARPPOC{
    interface ITechRound{
        void TechRound();
    }
    interface IHrRound{
        void HrRound();
    }
    class Interview: ITechRound, IHrRound{
        public void TechRound(){
            Console.WriteLine("This is tech round");
        }
        public void HrRound(){
            Console.WriteLine("This is Hr Round");
        }
    }
}
namespace SRAJENCSHARPPOC{
    class Sports{
        public virtual void Run(){
            Console.WriteLine("While Playing sports you have to run");
        }
    }
    class Cricket: Sports{
        public override void Run()
        {
            Console.WriteLine("While Playing cricket you have to run");
        }
    }
    class Football: Sports{
        public override void Run()
        {
            Console.WriteLine("While Playing Football you have to run");   
        }
    }
}
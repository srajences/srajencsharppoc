namespace SRAJENCSHARPPOC{
    class Planet{
        public void Atmosphere(){
            Console.WriteLine("Basic necessity for life");
        }
    }
    class Earth: Planet{
        public void Rotate(){
            Console.WriteLine("Earth Rotates");
        }
    }
    class Mars: Planet{
        public void Tempertaure(){
            Console.WriteLine("Temperature is High");
        }
    }
}
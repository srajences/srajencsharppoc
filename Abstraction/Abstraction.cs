namespace SRAJENCSHARPPOC{
    abstract class Gun{
        public abstract int range();
    }
    class Sniper: Gun{
        private int speed;
        private int targetSize;
        public Sniper(int s, int t){
            speed =s;
            targetSize = t;
        }
        public override int range()
        {
            return speed*targetSize;
        }

    }
}
namespace SRAJENCSHARPPOC{
    public static class PrimeNumber{
        public static void IsPrime(){
        int number,flag=0;
        Console.Write("Please Enter the number:");
        number = Convert.ToInt32(Console.ReadLine());
        if(number==0||number==1){
            flag=1;
        }
        else if(number==2){
            flag =0;
        }
        else
        {
            for(int i=2;i<=number/2;i++){
            if(number%i==0){
                flag=1;
                break;
            }
        }
        }

        if(flag==1){
            Console.Write("Your number is not prime");
        }
        else{
            Console.Write("Your number is prime");
        }
    }
    }
}
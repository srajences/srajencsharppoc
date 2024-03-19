namespace SRAJENCSHARPPOC{
    public static class BasicArray{
        public static void PrintArray(){
            int size,input;
            Console.Write("Please enter the size of Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[]number = new int[size];
            Console.Write("Please enter the value in array:");
            for(int i=0;i<size;i++){
                input = Convert.ToInt32(Console.ReadLine());
                number[i]=input;
            }
            Console.WriteLine("The array elements are:");
            for(int i=0;i<size;i++){
                Console.WriteLine(number[i]);
            }
        }
    }
}
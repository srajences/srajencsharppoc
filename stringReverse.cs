using System.Text;

namespace SRAJENCSHARPPOC{
    public static class StringReverse{
        public static void Reverse(){
            string String1;
            Console.WriteLine("Please enter the string:");
            String1 = Console.ReadLine();
            StringBuilder String2 = new StringBuilder();
            for(int i=String1.Length-1;i>=0;i--){
                String2.Append(String1[i]);
            }
            Console.WriteLine("The Reversed string is:"+String2.ToString());
        }
    }
}
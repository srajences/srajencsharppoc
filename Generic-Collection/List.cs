namespace SRAJENCSHARPPOC{
    public static class PracticeList{
        public static void ImplementList(){
            List<string>l1=new List<string>();
            l1.Add("Srajen");
            l1.Add("Singh");
            l1.Add("Hi");
            l1.Add("Hello");
            l1[3]="Back";
            l1.ForEach((item)=>{
                Console.WriteLine(item);
            });
            Console.WriteLine(l1.FindIndex(a=>a.Contains("Back")));
        }
    } 
}
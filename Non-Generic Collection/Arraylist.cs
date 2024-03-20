using System.Collections;

namespace SRAJENCSHARPPOC{
    public static class PracticeArrayList{
        public static void ImplementArrayList(){
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Srajen");
            al.Add(true);
            al.Add(23.55);
            al.Add(null);
            al.Add('a');
            int[]values={13,12,14};
            string[]names={"Srajen","Rahul"};
            al.AddRange(new[]{3,2,4});
            al.AddRange(values);
            al.AddRange(names);
            al.InsertRange(2,names);
            foreach(var elements in al){
                Console.WriteLine(elements);
            }
        }
    }
}
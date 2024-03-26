using System.Collections;

namespace SRAJENCSHARPPOC{
    public static class PracticeHashTables{
        public static void ImplementHashTables(){
            //They can't have duplicate keys
            Hashtable ht = new Hashtable();
            ht.Add(1,"Srajen");
            ht.Add(2,"Singh");
            ht.Add(1.1,"Decimal");
            ht.Add(1.2,"Pointer");
            ht.Add(true,"Boolean");
            ht.Add("hey","HI");
            foreach(var elements in ht){
                Console.WriteLine(elements);
            }
            foreach(DictionaryEntry de in ht){
                Console.WriteLine($"key: {de.Key} | value: {de.Value}");
            }
            Console.WriteLine(ht.ContainsValue("Srajen"));
        }
    }
}
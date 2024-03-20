namespace SRAJENCSHARPPOC{
    public static class PracticeDictionary{
        public static void ImplementDictionary(){
            Dictionary<int,string>dt = new Dictionary<int,string>();
            dt.Add(1,"Srajen");
            dt.Add(2,"Singh");
            dt.Add(3,"Hey");
            dt.Add(4,"Hello");
            foreach(KeyValuePair<int,string>kv in dt){
                Console.WriteLine($"Key: {kv.Key} and value: {kv.Value}");
            }
            var item = new KeyValuePair<int,string>(3,"Hey");
            Console.WriteLine(dt.Contains(item));
        }
    }
}
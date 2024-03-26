using System.Security.Cryptography;

namespace SRAJENCSHARPPOC{
    class Employee{
        private string name;
        private int id;
        public string GetName(){
            return name;
        }
        public void SetName(string name){
            this.name=name;
        }
        public int GetId(){
            return id;
        }
        public void setID(int id){
            if(id>0){
                this.id=id;
            }else{
                Console.WriteLine("Id cannot be negative");
            }
        }
    }
}
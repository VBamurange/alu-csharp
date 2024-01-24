using System.Collections;

class List{

    public static List<int> CreatePrint(int size){

        if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }else{
            List<int> theeList = new List<int>();
            for(int i = 0; i < size; i++){
                Console.Write(i + " ");
                theeList.Add(i);
            }
            Console.WriteLine();
            return theeList;
        }
    }
}
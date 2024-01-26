using System.Collections;
using System.Collections.Generic;

public class List{

    public static List<int> DeleteAt(List<int> myList, int index){
        int ListSize = myList.Count;
        List<int> theeList = new List<int>();

        if(index >= 0 && index < ListSize){
            for(int i = 0; i < ListSize; i++){
                if(i == index){
                   
                    continue;
                }else{
                       
                        theeList.Add(myList[i]);
                }
            
            }
           

            return theeList;
        }else{
            Console.WriteLine("Index is out of range");
            return myList;
        }

    }
}
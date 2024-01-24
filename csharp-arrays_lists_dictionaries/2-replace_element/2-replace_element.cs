using System.Collections;

class Array{
    public static int[] ReplaceElement(int[] array, int index, int n){
        int[] theeArray = array;
        int size = theeArray.Length;
        if(index >= 0 && index < size){
            theeArray[index] = n;
            return theeArray;
        }else{
            Console.WriteLine("Index out of range");
            return theeArray;
        }
    }
}

using System.Collections;

class Dictionary{

    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict){
        Dictionary<string, int> theeDict = new Dictionary<string, int>();
        foreach(KeyValuePair<string, int> temp in myDict){
            theeDict[temp.Key] = temp.Value * 2;
        }

        return theeDict;
    }
}

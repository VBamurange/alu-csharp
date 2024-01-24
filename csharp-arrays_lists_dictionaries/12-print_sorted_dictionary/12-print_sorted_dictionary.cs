using System.Collections;

class Dictionary{

    public static void PrintSorted(Dictionary<string, string> myDict){
        var theeKeys = myDict.Keys.OrderBy(key => key).ToList();

        foreach (var key in theeKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}

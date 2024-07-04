using System;

public class Item: BaseClass {
    public string? name { get; set; }

    public string? description { get; set; }

    private float price;
     public float Price {
        get { return (float)Math.Round(price, 2);}
        set {price = value; }
     }

   public List<string>? tags = new List<string>();

   public Item(string name) {
    this.name = name; 
   }
}
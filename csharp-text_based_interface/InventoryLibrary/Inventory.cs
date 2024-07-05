using System;
public class Inventory: BaseClass {

    public string? user_id { get; set; }
    public string? item_id { get; set; }
    public int quantity = 1;
        
        public Inventory(string user_id, string item_id, int quantity = 1) {
        user_id = user_id;
        item_id = item_id;
      
      if(this.quantity < 0) {
        this.quantity = 0;
      } else {
        this.quantity = quantity;
      }
    }
    
}


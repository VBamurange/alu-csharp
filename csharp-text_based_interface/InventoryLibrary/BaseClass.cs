using System;

public class BaseClass {

    public string? id {get; set ; }
    public DateTime datecreated { get; set; }
    public DateTime dateupdated { get; set; }

    public BaseClass() {
        id = Guid.NewGuid().ToString();
        datecreated = DateTime.Now;
        dateupdated = DateTime.Now;
    }
}
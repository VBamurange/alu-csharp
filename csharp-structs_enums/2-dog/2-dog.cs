using System;

enum Rating{
    Good,
    Great,
    Excellent,
}

struct Dog{

    public Dog(string dog_name, float dog_age, string dog_owner, Rating dog_rating){
        this.name = dog_name;
        this.age = dog_age;
        this.owner = dog_owner;
        this.rating = dog_rating;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
//parameter nelkuli konstruktor hasznalata peldanyositaskor
Fruit apple = new Fruit();
apple.Name = "Apple";
apple.Calories = 60;
apple.Price = 450;
apple.Importers.Add("ABCS");
apple.Importers = new List<string>(); //private set miatt nem lehet erteket adni

Fruit orange = new Fruit 
{ 
    Name = "Orange", 
    Calories = 90, 
    Price = 300 
};

//parameteres konstruktor hasznalata peldanyositaskor
Fruit banana = new Fruit("Banana", 89, 600);

Fruit gala = new Fruit(apple);
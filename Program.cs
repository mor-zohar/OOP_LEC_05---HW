// See https://aka.ms/new-console-template for more information

using LEC_05___HW;

Animals[] animalsArr = new Animals[3];
animalsArr[0] = new Animals("Dog","Bark");
animalsArr[1] = new Dog(15, "Dog", "Bark");
animalsArr[2] = new Cat("Black","Cat","Meow");

foreach(Animals a in animalsArr)
{
    Console.WriteLine(a.Print());
}
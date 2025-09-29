using System;

class Program
{
    static void Main() {
        Fruit apple = new Fruit(10, "Red");
        Fruit banana = new Fruit(5, "Yellow");
        Fruit grape = new Fruit(1, "Purple");

        apple.PrintInfo();
        banana.PrintInfo();
        grape.PrintInfo();
    }
}

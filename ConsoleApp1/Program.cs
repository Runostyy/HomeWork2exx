using System;

class Tvarina
{
    // Перший метод, що приймає два параметри: ім'я та вік
    public void ShowInfo(string name, int age)
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age} років");
    }

    // Другий метод, що приймає три параметри: вид, ім'я та вік
    public void ShowInfo(string species, string name, int age)
    {
        Console.WriteLine($"Вид: {species}, Ім'я: {name}, Вік: {age} років");
    }
}

class Program
{
    static void Main()
    {
        Tvarina tvarina = new Tvarina();

        // Виклик першого методу
        tvarina.ShowInfo("Мурчик", 3);

        // Виклик другого методу
        tvarina.ShowInfo("Кіт", "Мурчик", 3);
    }
}

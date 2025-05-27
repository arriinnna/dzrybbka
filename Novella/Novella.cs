using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в текстовую новеллу о сборе в школу!");
        StartGame();
    }

    static void StartGame()
    {
        Console.WriteLine("Ты только что встал с постели. Настало время собираться в школу.");
        Console.WriteLine("Что ты сделаешь? Напиши 'почистить зубы', чтобы приступить к этому шагу.");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "почистить зубы")
        {
            BrushTeeth();
        }
        else
        {
            Console.WriteLine("Ты не сделал этого. Попробуй снова.");
            StartGame();
        }
    }

    static void BrushTeeth()
    {
        Console.WriteLine("Ты почистил зубы. Теперь ты свеж и готов к новому дню!");
        Console.WriteLine("Что дальше? Напиши 'поесть завтрак', чтобы перекусить перед школой.");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "поесть завтрак")
        {
            HaveBreakfast();
        }
        else
        {
            Console.WriteLine("Ты не сделал этого. Попробуй снова.");
            BrushTeeth();
        }
    }

    static void HaveBreakfast()
    {
        Console.WriteLine("Ты поел завтрак. Чувствуешь себя бодро!");
        Console.WriteLine("Теперь можно одеться. Напиши 'одеться', чтобы перейти к этому шагу.");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "одеться")
        {
            GetDressed();
        }
        else
        {
            Console.WriteLine("Ты не сделал этого. Попробуй снова.");
            HaveBreakfast();
        }
    }

    static void GetDressed()
    {
        Console.WriteLine("Ты оделся и готов к выходу.");
        Console.WriteLine("Теперь нужно собрать рюкзак. Напиши 'собрать рюкзак'.");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "собрать рюкзак")
        {
            PackBackpack();
        }
        else
        {
            Console.WriteLine("Ты не сделал этого. Попробуй снова.");
            GetDressed();
        }
    }

    static void PackBackpack()
    {
        Console.WriteLine("Ты собрал рюкзак с книгами и учебниками.");
        Console.WriteLine("Теперь останется только выйти из дома. Напиши 'выйти', чтобы завершить сбор.");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "выйти")
        {
            CompleteGame();
        }
        else
        {
            Console.WriteLine("Ты не сделал этого. Попробуй снова.");
            PackBackpack();
        }
    }

    static void CompleteGame()
    {
        Console.WriteLine("Ты вышел из дома и направляешься в школу. Удачного дня!");
        Console.WriteLine("Спасибо за игру! Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}

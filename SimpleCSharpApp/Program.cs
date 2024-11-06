using System;

// Обратие внимание, что теперь возвращается int, а не void.
// Вывести сообщение и ожидать нажатия клавиши <Enter>.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Обработать любые входные аргументы.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}

Console.ReadLine();


// Возвратить произвольный код ошибки.
//return 0;
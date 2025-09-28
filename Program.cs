Console.WriteLine("напиши цвет твоєго героя On english becus u huv too");
string aboba = Console.ReadLine();
switch (aboba)
{
    case "blue":
        Console.WriteLine("Фея");
        break;
    case "red":
        Console.WriteLine("Дракон");
        break;
    case "green":
        Console.WriteLine("Лiсовик");
        break;
    case "potato":
        Console.WriteLine("МР. КАРТОШКА >:) и да ето не цвет");
        break;
    case "цвет твоєго героя On english becus u huv too":
        Console.WriteLine("Ну не впрямом смисле напиши ето все :/");
        break;
    case "ето все :/":
        Console.WriteLine("Да ну тя...");
        break;
    default:
        Console.WriteLine("нету токого, напиши ''green або red або blue и если хочеш potato");
        break;
}

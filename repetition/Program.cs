Console.WriteLine("Give me a an interger so i can caluclate your grade");
int UserInput = Convert.ToInt32(Console.ReadLine());
    
switch (UserInput)
{
    case 10:
    case 9:
        Console.WriteLine("you have a A+");
        break;
        
    case 7 or 8:
        Console.WriteLine("you have a B");
        break;
        
    case 6:
        Console.WriteLine("you have a C");
        break;
    case 5:    
        Console.WriteLine("you have a E");
        break;
    case <= 4:
        Console.WriteLine("you have a F");
        break;
    default:
        Console.WriteLine("type a number between 10 and 0"); 
        break;
}
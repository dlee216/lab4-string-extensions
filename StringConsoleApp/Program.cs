using StringExtensionsLib;

string? input = args.Length > 0
    ? string.Join(' ', args)
    : PromptForInput();

if (input is null)
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

Console.WriteLine($"Input: \"{input}\"");
Console.WriteLine($"Starts with uppercase letter? {input.IsStartsWithUpper()}");

static string? PromptForInput()
{
    Console.Write("Enter a string: ");
    return Console.ReadLine();
}

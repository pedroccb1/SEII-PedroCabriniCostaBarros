Console.WriteLine(Warning.CodeYellow);

var status = Warning.CodeYellow;

if(status == Warning.CodeYellow)
{
    Console.WriteLine("CODE YELLOW");
}

enum Warning
{
    CodeRed,
    CodeBlue,  
    CodeYellow,
}
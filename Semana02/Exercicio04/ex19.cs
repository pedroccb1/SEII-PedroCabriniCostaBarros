Action loggerAction = () =>
{
    System.Console.WriteLine("This is simple");
};

loggerFunc<int, int> loggerFunc = (int x) =>
{
    return x + 2;
};

var list = Enumerable.Range(1,10).Select(in => int*3).ToList();

var callCall = (lAction func) =>
{
    func();
};

callCall(loggerAction);

// instantiate printer object from outside like: main() or test code : printer

public class ConcreteCalculator : ICalculator
{
    public int Add(int x, int y)
    {
		printer.PrintLog("Add",x,y);
        var addition = x + y;
		printer.PrintLog("Add result",addition);
        return addition;
    }
}

public class ConsoleLogPrinter : IPrintLogPrinter
{
    public int PrintLog(string method, list<T> values)
    {
		 // print parameters to console
    }	
}

public class FileLogPrinter : IPrintLogPrinter
{
    public int PrintLog(string method, list<T> values)
    {
		 // print parameters to file 
    }
	
}


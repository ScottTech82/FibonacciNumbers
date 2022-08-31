using System.Diagnostics;

//pasted in from Teams chat
string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //putting file on desktop
var streamWriter = File.CreateText(Path.Combine(folderPath, "appTrace.log")); //creates a file, path folder plus apptrace.log
var traceWriter = new System.Diagnostics.TextWriterTraceListener(streamWriter);//creating streamwriter and making it a listener.
System.Diagnostics.Trace.Listeners.Add(traceWriter);
System.Diagnostics.Trace.AutoFlush = true; //flushing the cache

Console.WriteLine("Fibonacci!");

//Creating the Fibonacci sequence
// starts 1,1, then sum of prior 2 numbers 1, 1, 2, 3, 5, 8, 13, ...

//create a sequence until a number goes greater than 100.

int a = 1;
int b = 1;
int c = 0; 

while (c < 100)
{
    c = Add(a, b);
    Debug.WriteLine($"a = {a}, b = {b}, c = {c}"); //chapter 3 debugging
    Trace.TraceInformation($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine($"{c},");
    a = b;
    b = c;
}

int Add(int a, int b)
{
    return a + b;
}

//int d = b + (a + b); // 1+(1+1) = 2
//int e = (a + b) + b + (a + b); // 2+3 = 5







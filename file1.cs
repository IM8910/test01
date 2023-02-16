// See
// for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");

//commit5

var p1 = new SampT();
Console.WriteLine(p1.DoSometh());
var person1 = new Person();
var person2 = new Person();
person1.Name = "Bob";
person2.Name = "bob";

bool result = person1.Equals(person2);

Teacher teacher = new Teacher( "Obama") ;
string TRQ = "FFF";
string srw = teacher.GetFullName(TRQ);
CurrecncyTrader ct = new CurrecncyTrader();
ct.PrintSomething();
ct.Name = "fasdfasdf";
ct.Description = "string>";
Console.WriteLine(ct.Name);
Console.WriteLine(ct.Description);
Console.WriteLine(ct.ToString()); 
Console.WriteLine(ct.GetType());
Console.ReadKey();

Book book = new Book("sdfasd", "gdfsgdsf");
//Book book = new Book();
book.Name = "try";
book.Autor = "test";
Console.WriteLine(book.Name);
Console.WriteLine(book.Autor);

string sr = "Hello";
string tr = "Hello";

if (sr.Equals(tr))
{
    Console.WriteLine("they are equalll");
}
else Console.WriteLine("they are not");

sr.ToUpper();
Console.WriteLine(sr);
Console.WriteLine(sr.ToUpper());
Console.WriteLine(sr.ToUpper().GetHashCode());
string sd = "HELLO";
string ssd1 = sr.ToUpper();
var er11 = sd.GetHashCode();
var er21 = ssd1.GetHashCode();
Console.WriteLine(er11);
Console.WriteLine(er21);
//Console.WriteLine(er);
//Console.WriteLine(er2);
Console.WriteLine("final");
//Console.WriteLine(sr);
int [] ar1= {0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10,12,14,16};
for (int i = ar1.Length-1; i >=0 ; --i)
{
    Console.WriteLine(ar1[i]);

}
foreach (int i in ar1)
{
    Console.WriteLine(i);
}

List<int> ar2 = new List<int>() { 1000, 1, 3, 65, 7867, 4, 54, 31, 2, 3, 4, 5, 6, 7, 8, 9, 10, 4, 654, 23, 5, 7, 56, 3, 5, 54, 7, 867, 9, -1, -3, -5, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 1, 2, 2, 2, 2, 0, 2, 2, 2, 2, 7 };
ar2.AddRange(ar1.ToList());
IEnumerable<int> ar3 = ar2.Where(x => x > 0);
IEnumerable<int> ar4 = ar3.Where(x => x>0 ).Where(x =>x<10);
foreach (int i in ar3)
{ Console.WriteLine(i); }

Console.WriteLine(DateTime.Now);
for (int i = 0; i < 30; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizz buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i%5==0){ Console.WriteLine("buzz"); }
    else Console.WriteLine(i);
}

string tyu= @"C:\users\ihor.mysak\source\repos\ConsoleApp3\ConsoleApp3\New Text Document.txt";
//FileStream fd = new FileStream(tyu, FileMode.Open );
//byte [] ffd = File
StreamWriter sw = new StreamWriter(tyu);
sw.WriteLine("ok, let's try 2");
sw.WriteLine("ok, let's try 3");
sw.WriteLine("ok, let's try 4");
sw.WriteLine("ok, let's try 5");
sw.WriteLine("ok, let's try 1");
sw.Close();
StreamReader sr1 = new StreamReader(tyu);
string? aro1 = sr1.ReadToEnd();
var inc = sr1.CurrentEncoding;
sr1.Dispose();

Console.WriteLine(DateTime.Now);





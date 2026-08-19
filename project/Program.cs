//Console.WriteLine("Hello, World!");
string[] names = new string[3];
names[0] = "Lucas"; 
names[1] = "João";
names[2] = "Maria";
Console.WriteLine(names[0]);
string[] names2 = new string[3] { "Lucas", "João", "Maria" };
Console.WriteLine(names2[1]);
System.Console.WriteLine(names2.Length);
System.Console.WriteLine(names2.Any());
string [] names3 = { "anna", "marcio", "bruno" };
var names4 = names3.Append("lucas");
foreach (var item in names3)
{
    System.Console.WriteLine(item);
}
var all = names3.Concat(names4);
foreach (var item in all)   
{
    System.Console.WriteLine(item);
}
names.clear();
names2.clear();
names3.clear();
names4.clear();
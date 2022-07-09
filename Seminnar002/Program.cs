Console.Write("a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
string result;
if(numberA * numberA == numberB) 
{
  result = "да";
}
else 
{
  result = "нет";
}
Console.WriteLine(result);

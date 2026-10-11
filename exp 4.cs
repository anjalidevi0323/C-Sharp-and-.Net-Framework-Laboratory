using System;
class Number
{
 public int value;
 public Number(int x)
 {
 value = x;
 }
 public static Number operator ++(Number n)
 {
 n.value++;
 return n;
 }
 public static Number operator +(Number a, Number b)
 {
 return new Number(a.value + b.value);
 }
 public void Display()
 {
 Console.WriteLine("Value = " + value);
 }
}
class Program
{
 static void Main(string[] args)
 {
 Number n1 = new Number(10);
 Number n2 = new Number(20);
 Console.WriteLine("Before Unary Operator:");
 n1.Display();
 ++n1;
 Console.WriteLine("After Unary Operator:");
 n1.Display();
 Number n3 = n1 + n2;
 Console.WriteLine("After Binary Operator (+):");
 n3.Display();
 Console.ReadKey();
 }
}
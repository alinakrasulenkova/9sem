// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите 1 неотрицательное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 неотрицательное число");
int n = Convert.ToInt32(Console.ReadLine());

int funсAk = Ak(m, n);

Console.Write(funсAk);

int Ak(int m, int n)
{
  if (m == 0) 
  return n + 1;
  
  else if (n == 0) 
  return Ak(m - 1, 1);
  
  else 
  return Ak(m - 1, Ak(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
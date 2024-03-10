//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Clear();
int m = 0;
int n = 1;
int Akcerman(int m, int n)
{
  if (m == 0)
    {
      return n + 1;
      }
  else if (m > 0 && n == 0)
    {
      return Akcerman(m - 1, 1);
      }
  else if (m>0 && n> 0)
    {
      return Akcerman(m - 1, Akcerman(m, n - 1));
      }
  return -1;
}
Console.Write(Akcerman(m, n));
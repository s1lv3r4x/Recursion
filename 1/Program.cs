//Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. Использовать рекурсию, 
//не использовать циклы.


int M=2;
int N=10;
Console.Clear();
void Numbers(int m,int n)
{
    if (n == m-1)
    {
        
    return;
    }
    else
    {
         
Numbers(m,n-1);
Console.Write(n +" ");  
}
}
Numbers(M,N);

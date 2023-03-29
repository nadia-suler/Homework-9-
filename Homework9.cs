/*
    // Task 64: Set the value to N. Write a program that prints all natural numbers between N and 1. Execute using recursion.

  int N = InputNumber("Input a positive number: ");
   int M = 1;

    int Numbers(int N, int M)
{
    if (N == M)
        return N;
    else
        Console.Write($"{Numbers(N, M + 1)} ");
    return M;
}

    Console.WriteLine(Numbers(N, M));
    
    int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
   */    

/*
    // Task 66: Give values M and N. Write a program that will find the sum of positive integers between M and N.

int M = InputNumber("Input M: ");
int N = InputNumber("Input N: ");
Console.WriteLine($"Sum of elements from {M} to {N} = {Sum(M, N)}");

int Sum(int M, int N)
{
    if (M == N)
        return N;
  else
  {
    return N + Sum(M, N - 1);
  }
}


int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/
    
/*
    // Task 68: Write a program to calculate the Ackermann function using recursion. Two non-negative numbers m and n are given.

int M = InputNumber("Input M: ");
int N = InputNumber("Input N: ");
Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");

int Akkerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M > 0 && N == 0)
        return Akkerman(M - 1, 1);
    else
        return Akkerman(M - 1, Akkerman(M, N - 1));
}

    
int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
  */
    

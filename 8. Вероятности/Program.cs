using System;

class Program
{
    static void Main()
    {

        int n = 10;  
        double p = 0.5;  
        int k = 5;  
        double binomialProbability = BinomialProbability(n, k, p);
        Console.WriteLine($"Binomial Probability (n={n}, k={k}, p={p}): {binomialProbability}");

      
        int N = 50;  
        int K = 5; 
        int nDraws = 10;  
        int kSuccesses = 2;  
        double hypergeometricProbability = HypergeometricProbability(N, K, nDraws, kSuccesses);
        Console.WriteLine($"Hypergeometric Probability (N={N}, K={K}, n={nDraws}, k={kSuccesses}): {hypergeometricProbability}");

        
        double geomP = 0.2;  
        int x = 3; 
        double geometricProbability = GeometricProbability(geomP, x);
        Console.WriteLine($"Geometric Probability (p={geomP}, x={x}): {geometricProbability}");

       
        double lambda = 3.0; 
        int kEvents = 4;  
        double poissonProbability = PoissonProbability(lambda, kEvents);
        Console.WriteLine($"Poisson Probability (lambda={lambda}, k={kEvents}): {poissonProbability}");
    }

    static double BinomialProbability(int n, int k, double p)
    {
        return Combination(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
    }

    static double HypergeometricProbability(int N, int K, int n, int k)
    {
        return (Combination(K, k) * Combination(N - K, n - k)) / Combination(N, n);
    }

    static double GeometricProbability(double p, int x)
    {
        return Math.Pow(1 - p, x - 1) * p;
    }

    static double PoissonProbability(double lambda, int k)
    {
        return Math.Pow(lambda, k) * Math.Exp(-lambda) / Factorial(k);
    }

    static double Combination(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

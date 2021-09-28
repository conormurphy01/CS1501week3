//Dylan Dockery 
//dbd2f
public class Solution
{
    public double MyPow(double x, int n)
    {
        //base case: if n =2 return x*x
        if (n == 1)
        {
            return x;
        }
        //if n is negative retrun 1 divided by x^n
        else if (n < 0)
        {
            return (1.0 / MyPow(x, -n));
        }

        //if n is odd return x 
        else if (n % 2 == 1)
        {
            return x * (MyPow(x, n - 1));
        }
        else
        {
            double temp = MyPow(x, (n) / 2);
            return temp * temp;

        }

    }
}

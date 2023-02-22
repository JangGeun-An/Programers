public class 최대공약수와_최소공배수  {
    public int[] solution(int n, int m) {
        int gcd1 = gcd(n,m);
        int[] answer = new int[]{gcd1, n*m/gcd1};
        return answer;
    }
    
    int gcd(int a, int b)
    {
        return (a%b == 0 ? b : gcd(b, a%b));
    }
}
using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n%2==1) for(int i=1; i<=n; i+=2) answer += i;
        else for(int i=0; i<=n; i+=2) answer += i*i;
        return answer;
    }
}

// 등차수열의 합, 자연수 거듭제곱의 합 공식을 이용
// public class Solution {
//     public int solution(int n) {
//         if(n%2 == 1) return (n+1)/2*((n+1)/2);
//         else return n*(n+1)*(n+2)/6;
//     }
// }
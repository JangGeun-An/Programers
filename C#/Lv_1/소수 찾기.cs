using System;

public class 소수_찾기 {
    public int solution(int n) {
        int answer = 0;
        for(int i=2; i<=n; i++) if(IsSosu(i)==true) answer++;    
        return answer;
    }
    
    public bool IsSosu(int num) {
        for(int i=2; i*i<=num; i++) if(num%i == 0) return false;
        return true;
    }
}
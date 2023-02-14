using System;

public class 문자열_밀기 {
    public int solution(string A, string B) {
        int answer = 0;
        if(A == B) return 0;
        for (int i=0; i<A.Length-1; i++) 
        {
            char C = A[A.Length-1];
            A = C + A;
            A = A.Substring(0, A.Length-1);
            answer ++;
            if (A == B) return answer;
        }
        return -1;

        // 2번째 방법, 매우 간단함!!
        //int answer = (B+B).IndexOf(A);
        //return answer;
    }
}
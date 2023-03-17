using System;

public class 문자열_내_마음대로_정렬하기 {
    public string[] solution(string[] strings, int n) {
        string[] answer = strings;
        for(int i=0; i<strings.Length; i++)
            answer[i] = answer[i][n] + answer[i];
        Array.Sort(answer);
        for(int i=0; i<strings.Length; i++)
            answer[i] = answer[i].Substring(1);
        return answer;

        // 가장 간단한 방법!!
        // string[] answer = strings.OrderBy(c => c[n]).ThenBy(c => c).ToArray();
        // return answer;
    }
}
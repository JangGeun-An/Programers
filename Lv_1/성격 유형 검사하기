using System;
using System.Collections.Generic;

public class 성격_유형_검사하기 {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<string, int> result = new Dictionary<string, int>()
        {{"R", 0}, {"T", 0}, {"C", 0}, {"F", 0}, {"J", 0}, {"M", 0}, {"A", 0}, {"N", 0}};
        
        for(int i=0; i<survey.Length; i++)
        {
            if(choices[i] <= 3) result[survey[i][0].ToString()] += 4-choices[i];
            else if(choices[i] >= 5) result[survey[i][1].ToString()] += choices[i]-4;
            else continue;
        }
        answer += result["R"] >= result["T"] ? 'R' : 'T';
        answer += result["C"] >= result["F"] ? 'C' : 'F';
        answer += result["J"] >= result["M"] ? 'J' : 'M';
        answer += result["A"] >= result["N"] ? 'A' : 'N';
        return answer;
    }
}
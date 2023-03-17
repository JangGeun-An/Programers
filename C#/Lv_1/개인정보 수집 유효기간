using System;
using System.Collections.Generic;

public class 개인정보_수집_유효기간 {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        int todayYear = int.Parse(today.Split('.')[0]);
        int todayMonth = int.Parse(today.Split('.')[1]);
        int todayDay = int.Parse(today.Split('.')[2]);
        int todaySum = (todayYear * 12 * 28) + (todayMonth * 28) + todayDay;        
        
        Dictionary<string,int> term = new Dictionary<string,int>();
        for(int i = 0; i < terms.Length; i++) 
            term.Add(terms[i].Split(' ')[0], int.Parse(terms[i].Split(' ')[1]));
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string[] temp = privacies[i].Split('.', ' ');
            int year = int.Parse(temp[0]);
            int month = int.Parse(temp[1]) + term[temp[3]];
            int day = int.Parse(temp[2]);
            int sum = (year * 12 * 28) + (month * 28) + day - 1;
            
            if(todaySum > sum) answer.Add(i + 1);
        }        
        return answer.ToArray();
    }
}
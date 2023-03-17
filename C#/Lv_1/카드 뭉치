using System;
using System.Collections.Generic;

public class 카드_뭉치 {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        List<string> card1 = new List<string>(cards1);
        List<string> card2 = new List<string>(cards2);
        
        for(int i=0; i<goal.Length; i++)
        {
            if(card1.Count > 0 && card1[0] == goal[i]) card1.RemoveAt(0);
            else if(card2.Count > 0 && card2[0] == goal[i]) card2.RemoveAt(0);
            else return "No";
        }
        return "Yes";
    }
}
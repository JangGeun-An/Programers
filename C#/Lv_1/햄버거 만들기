using System;
using System.Collections.Generic;

public class 햄버거_만들기 {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ingre = new List<int>();
        
        foreach(int burger in ingredient)
        {
            ingre.Add(burger);
            if(ingre.Count >= 4)
                if(ingre[ingre.Count-4] == 1 && ingre[ingre.Count-3] == 2 &&
                   ingre[ingre.Count-2] == 3 && ingre[ingre.Count-1] == 1)
                {
                    answer++;
                    ingre.RemoveRange(ingre.Count - 4, 4);
                }
        }
        return answer;
    }
}
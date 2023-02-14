using System;
using System.Linq;
using System.Collections.Generic;

public class 두_개_뽑아서_더하기 {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>();
        for(int i=0; i<numbers.Length-1; i++)
            for(int j=i+1; j<numbers.Length; j++)
                list.Add(numbers[i]+numbers[j]);
        int[] answer = list.Distinct().ToArray();
        Array.Sort(answer);
        return answer;
    }
}
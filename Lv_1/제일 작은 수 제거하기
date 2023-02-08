using System.Collections.Generic;
using System.Linq;

public class 제일_작은_수_제거하기 {
    public int[] solution(int[] arr) {
        List<int> answer = arr.ToList();
        if(arr.Length == 1) answer.Add(-1);
        answer.Remove(arr.Min());
        return answer.ToArray();
    }
}
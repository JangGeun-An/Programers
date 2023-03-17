using System.Collections.Generic;

public class 자연수_뒤집어_배열로_만들기 {
    public int[] solution(long n) {
        List<int> answer = new List<int>();
        while(n>0)
        {
            answer.Add((int)(n%10));
            n = n / 10;
        }
        return answer.ToArray();

        // 2번 방법, 문자열로 변환후 한자리씩 잘라서 뒤집기
        //string nString = new string(n.ToString().ToCharArray().Reverse().ToArray());
        //int[] answer = new int[nString.Length];
        //for (int i = 0; i < nString.Length; i++)
        //    answer[i] = int.Parse(nString[i].ToString());
    }
}
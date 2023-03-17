using System;

public class 영어가_싫어요 {
    public long solution(string numbers) {
        string[] str = {"zero","one","two","three","four","five","six","seven","eight","nine"};
        for(int i=0; i<str.Length; i++)
            numbers = numbers.Replace(str[i], i.ToString());
        long answer = long.Parse(numbers);
        return answer;
    }
}
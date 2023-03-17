public class 서울에서_김서방_찾기 {
    public string solution(string[] seoul) {
        string answer = "김서방은 ";
        for(int i=0; i<seoul.Length; i++)
            if(seoul[i] == "Kim") answer += i +"에 있다";
        return answer;
    }
}
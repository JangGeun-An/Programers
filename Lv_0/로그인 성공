using System;

public class 로그인_성공 {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        string str = "";
        for(int i=0; i<db.Length/2; i++)
        {
            if(id_pw[0] == db[i,0])
            {
                str = "wrong pw";
                if(id_pw[1] == db[i,1]) answer = "login";
            }
            if(answer == "login") break;
            else answer = "fail";
            if(str == "wrong pw") answer = "wrong pw";
        }
        return answer;

        // 2번 방법 더 간단함!! answer를 사용하지 않고 결과를 바로 리턴
        // for(int i=0; i<db.Length/2; i++)
        // {
        //     if(id_pw[1] == db[i,1] && id_pw[0] == db[i,0]) return "login";
        //     else if(id_pw[0] == db[i,0]) return "wrong pw";
        // }
        // return "fail";
    }
}
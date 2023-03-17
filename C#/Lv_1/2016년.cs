using System;

public class a2016년 {
    public string solution(int a, int b) {
        string answer = "";
        int month = 1;
        int days = 1;
        int i = 4;
        string[] day = {"MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"};
        while(month != a || days != b)
        {
            if(i == 6) i = 0;
            else i++;
            
            if((month == 1 || month == 3 || month == 5 || month == 7 ||
               month == 8 || month == 10 ||month == 12) && days == 31)
            {
                days = 1;
                month++;
            }
            else if((month == 4 || month == 6 || month == 9 || month == 11) && days == 30)
            {
                days = 1;
                month++;
            }
            else if(month == 2 && days == 29)
            {
                days = 1;
                month++;
            }
            else days++;
        }
        answer = day[i];
        return answer;

        // 명령어를 이용한 간단한 방법
        // DateTime dateValue = new DateTime(2016,a,b);
        // answer = dateValue.DayOfWeek.ToString().Substring(0,3).ToUpper();
    }
}
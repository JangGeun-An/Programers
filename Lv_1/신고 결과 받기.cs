using System;
using System.Linq;
using System.Collections.Generic;

public class 신고_결과_받기 {
    public int[] solution(string[] id_list, string[] report, int k) {
        // 제일먼저 중복 신고는 제외
        report = report.Distinct().ToArray();

        Dictionary<string, int> dicIdList = new Dictionary<string, int>();
        Dictionary<string, int> dicAnswer = new Dictionary<string, int>();

        for ( int i=0; i< id_list.Length; i++)
        {
            dicIdList.Add(id_list[i], 0);
            dicAnswer.Add(id_list[i], 0);
        }

        // 피신고자의 각각 신고당한 횟수 
        foreach (string r in report)
        {
            string target = r.Split(' ')[1];
            dicIdList[target] += 1;
        }

        // k번째이상 피신고자만 
        List<string> stopUserList = new List<string>();
        foreach (var d in dicIdList)
            if (d.Value >= k) stopUserList.Add(d.Key);

        // k번이상 피신고자를 신고한 유저
        foreach (string r in report)
        {
            string user = r.Split(' ')[0];
            string target = r.Split(' ')[1];

            foreach(string stopId in stopUserList)
                // stop유저를 신고한 id 의 신고 횟수
                if(stopId == target) dicAnswer[user] += 1;
        }

        // Dictionary => 반환형 int[] 
        return dicAnswer.Values.ToArray();
    }
}
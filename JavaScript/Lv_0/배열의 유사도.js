function solution(s1, s2) {
    var answer = 0;
    for(let i=0; i<s1.length; i++)
        for(let j=0; j<s2.length; j++)
            if(s1[i] === s2[j]) answer++;
    return answer;
}

// filter를 사용하면 더 간단하다.
// function solution(s1, s2) {
//     return s1.filter(x => s2.includes(x)).length;
// }
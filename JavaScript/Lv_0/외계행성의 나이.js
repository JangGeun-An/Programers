function solution(age) {
    let answer = '';
    age = String(age);
    for(let ch of age)
        {
            if(ch === '0') answer += 'a';
            else if(ch === '1') answer += 'b';
            else if(ch === '2') answer += 'c';
            else if(ch === '3') answer += 'd';
            else if(ch === '4') answer += 'e';
            else if(ch === '5') answer += 'f';
            else if(ch === '6') answer += 'g';
            else if(ch === '7') answer += 'h';
            else if(ch === '8') answer += 'i';
            else if(ch === '9') answer += 'j';
        }
    return answer;
}

// 더 간단한 방법
// function solution(age) {
//     return age.toString().split("").map(v => "abcdefghij"[v]).join("");
// }
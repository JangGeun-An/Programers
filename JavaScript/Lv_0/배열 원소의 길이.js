function solution(strlist) {
    var answer = [];
    for(let i of strlist) answer.push(i.length);
    return answer;
}

//map 또는 reduce로 가능함
// function solution(strlist) {
//     return strlist.map((el) => el.length)
// }

// function solution(strlist) {
//     return strlist.reduce((a, b) => [...a, b.length], [])
// }
function solution(my_string) {
    var answer = [];
    my_string = my_string.replace(/[^0-9]/g, "").split("");
    for(let i of my_string) answer.push(Number(i));
    return answer.sort((a,b) => a-b);
}

// 더 요약한 방법
// function solution(my_string) {
//     return my_string.match(/\d/g).sort((a, b) => a - b).map(n => Number(n));
// }

// 또 다른 방법
// function solution(my_string) {
//     return my_string.replace(/[^\d]/g,'').split('').map(v=>+v).sort();
// }
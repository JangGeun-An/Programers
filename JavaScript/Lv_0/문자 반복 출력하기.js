function solution(my_string, n) {
    var answer = '';
    for(let i=0; i<my_string.length; i++)
        for(let j=0; j<n; j++)
            answer = answer.concat(my_string[i]);
    return answer;
}

// map과 repeat, join을 이용하면 간단하다.
// function solution(my_string, n) {
//     var answer = [...my_string].map(v => v.repeat(n)).join("");
//     return answer;
// }
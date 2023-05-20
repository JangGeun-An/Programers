function solution(my_string, index_list) {
    let answer = "";
    for(let i of index_list) answer += my_string[i];
    return answer;
}

// map과 join을 이용한 간단한 방법
// function solution(my_string, index_list) {
//     return index_list.map(x => my_string[x]).join('');
// }
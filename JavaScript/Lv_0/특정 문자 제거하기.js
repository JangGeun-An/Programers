function solution(my_string, letter) {
    let answer = '';
    for(let i=0; i<my_string.length; i++)
        if(my_string[i] !== letter)
            answer = answer.concat(my_string[i]);
    return answer;
}

// replaceAll을 사용하면 더 간단하다.
// function solution(my_string, letter) {
//     return my_string.replaceAll(letter, "");
// }

// 또는 split으로 letter를 구분자로 사용하여 구분 후 join으로 다시 붙여도 된다.
// function solution(my_string, letter) {
//     const answer = my_string.split(letter).join('')
//     return answer;
// }
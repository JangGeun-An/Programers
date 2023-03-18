function solution(array) {
    array.sort();
    let answer = array.sort((a,b) => a-b)[~~(array.length/2)];
    return answer;
}
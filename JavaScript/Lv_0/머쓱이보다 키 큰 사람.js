function solution(array, height) {
    let answer = array.filter(k => k>height).length;
    return answer;
}
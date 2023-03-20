function solution(numbers, num1, num2) {
    return numbers.splice(num1, num2-num1+1);
}

// 또는 slice를 이용한다.
// function solution(numbers, num1, num2) {
//     return numbers.slice(num1, num2+1);
// }
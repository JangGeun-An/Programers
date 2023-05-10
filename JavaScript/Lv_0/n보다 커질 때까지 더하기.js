function solution(numbers, n) {
    return numbers.reduce((x, y) => x<=n ? x+y : x);
}
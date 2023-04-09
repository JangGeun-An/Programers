function solution(numbers) {
    numbers.sort((a,b) => b-a);
    let first = numbers[0] * numbers[1];
    let second = numbers[numbers.length-1] * numbers[numbers.length-2];
    return first > second ? first : second;
}
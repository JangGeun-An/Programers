function solution(a, b) {
    const A = a % 2 == 1
    const B = b % 2 == 1

    if(A && B) return Math.pow(a, 2) + Math.pow(b, 2)
    if(!A && !B) return Math.abs(a - b)
    return 2 * (a + b)
}
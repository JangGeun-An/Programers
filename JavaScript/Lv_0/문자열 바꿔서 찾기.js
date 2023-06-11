function solution(myString, pat) {
    myString = myString.replaceAll("A","b").replaceAll("B","a").toUpperCase();
    return myString.includes(pat) ? 1 : 0;
}

// 더 간단한 방법, myString을 배열화 후 map으로 문자변환을 한다
// function solution(myString, pat) {
//     return [...myString].map(x => x == 'A' ? 'B' : 'A').join('').includes(pat) ? 1 : 0;
// }
function solution(num_list) {
    return num_list.reduce((a,c) => a+c)**2 > num_list.reduce((a,c) => a*c) ? 1 : 0;
}
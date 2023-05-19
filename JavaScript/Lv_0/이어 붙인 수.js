function solution(num_list) {
    var hol = "", jak = "";
    for(let i of num_list)
        {
            if(i%2 == 0) hol += i;
            else jak += i;
        }
    return ~~hol + ~~jak;
}
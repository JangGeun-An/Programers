function solution(arr1, arr2) {
    if(arr1.length == arr2.length)
    {
        const a1 = arr1.reduce((a, c)=> a+=c);
        const a2 = arr2.reduce((a, c)=> a+=c);
        
        return a1 == a2 ? 0 : a1 > a2 ? 1 : -1 ;
    }
    else return arr1.length > arr2.length ? 1 : -1;
}
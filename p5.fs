
let sequence = seq {1 .. 700}


let numberList = Seq.toList sequence

let filteredList = List.filter (fun x -> x % 7 = 0 && x % 5 = 0) numberList


let sumOfFilteredNumbers = List.fold (+) 0 filteredList

printfn "%A" filteredList
printfn "The sum of all numbers that are multiples of both 7 and 5 is %d" sumOfFilteredNumbers

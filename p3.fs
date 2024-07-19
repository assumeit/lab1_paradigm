let productOfOdd (n: int) =
    let rec helper (current: int) (acc: int) =
        if current <= 0 then acc
        else helper (current - 2) (acc * current)
    helper n 1

let result = productOfOdd 11
printfn "The product of all odd numbers from 11 to 1 is %d" result

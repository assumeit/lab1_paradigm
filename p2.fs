printfn "Hello from F#"


let rec productTailRec acc list =
    match list with
    | [] -> acc
    | head :: tail -> productTailRec (acc * head) tail

let product list =
    productTailRec 1 list


let listOfNumbers = [1; 2; 3; 4; 5]
printfn "Product of elements: %d" (product listOfNumbers)

let power exponent baseValue =
    pown baseValue exponent

// Partially apply the function to create specialized functions
let square = power 2
let cube = power 3

// Test the partially applied functions
let resultSquare1 = square 4
let resultSquare2 = square 5

let resultCube1 = cube 2
let resultCube2 = cube 3

printfn "Square of 4 is %d" resultSquare1
printfn "Square of 5 is %d" resultSquare2
printfn "Cube of 2 is %d" resultCube1
printfn "Cube of 3 is %d" resultCube2

let trimTheGivenSpace (givenList: string list) = 
    givenList |> List.map (fun x -> x.Trim())

let list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = trimTheGivenSpace list
trimmedNames |> List.iter (printfn "%s")

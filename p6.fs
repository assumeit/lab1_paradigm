let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter all the elements that have the letter 'i' (case-insensitive)
let filteredNames: string list = List.filter (fun name -> name.Contains("i", System.StringComparison.OrdinalIgnoreCase)) names

// Concatenate all the resulting names using the fold function
let concatenatedNames: string = List.fold (fun acc name -> acc + name) "" filteredNames

printfn "Concatenated names containing 'i': %s" concatenatedNames

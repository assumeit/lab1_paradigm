let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]


let filteredNames: string list = List.filter (fun name -> name.Contains("i", System.StringComparison.OrdinalIgnoreCase)) names


let concatenatedNames: string = List.fold (fun acc name -> acc + name) "" filteredNames

printfn "Concatenated names containing 'i': %s" concatenatedNames

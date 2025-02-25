open System

let readL () =
    printf "Enter numbers with space between: "
    let inp = (Console.ReadLine())
    inp.Split(' ')
    |> Array.map int
    |> List.ofArray
    |> List.rev

let numb = readL()
printfn "List of numbers in reverse order: %A" numb


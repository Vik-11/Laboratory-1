open System

let reci x = 1.0 / x

let readL () =
    printf "Enter numbers with space between: "
    let inp = (Console.ReadLine())
    inp.Split(' ')
    |> Array.map double
    |> Array.map reci
    |> List.ofArray

let numb = readL()
printfn "List of reciprocal numbers: %A" numb


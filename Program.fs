open System

let reci x = 1.0 / x

let readL () =
    printf "Enter numbers with space in between: "
    let inp = (Console.ReadLine())
    inp.Split(' ')
    |> Array.map (fun s ->
    match Double.TryParse(s) with
            | true, n -> Some n
            | false, _->
                printfn "%s is not a number " s
                None)
    |> Array.choose id
    |> Array.filter (fun x -> x <> 0.0)
    |> Array.map reci
    |> List.ofArray

let numb = readL()
printfn "List reciprocal numbers: %A" numb

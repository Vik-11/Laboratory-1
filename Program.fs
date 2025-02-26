open System

let rec getNum() = 
    printf "Enter natural number: "
    let n = Console.ReadLine()
    match Int32.TryParse(n) with
    | true, n when n > 0 -> n
    | true, _ -> 
        printfn "Try number more than zero " 
        getNum()
    | false, _ ->
        printfn "Try integer" 
        getNum()

let countEven N = 
    let rec loop numb count =
        if numb = 0 then count
        else
            let digit = numb % 10
            let newCount = 
                if digit % 2 = 0 then count + 1 
                else count
            loop (numb / 10) newCount
    loop N 0

let n = getNum()
let res = countEven n
printfn "Quantity of even digits in number %d: %d" n res
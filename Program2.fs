open System

printf "Enter natural number: "
let n = int(Console.ReadLine())

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

let res = countEven n
printfn "Quantity of even digits in number %d: %d" n res

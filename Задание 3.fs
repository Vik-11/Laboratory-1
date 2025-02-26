open System

let readC prompt = 
   printfn "%s" prompt
   printf "Enter real part: "
   let rP = 
       match Double.TryParse(Console.ReadLine()) with
       | true, num -> num 
       | false, _ -> 
           printfn "Input error. Base value set to 0.0"
           0.0
   printfn "Enter imaginary part: "
   let iP =
       match Double.TryParse(Console.ReadLine()) with
       | true, num -> num
       |false, _ ->
           printfn "Input error. Base value set to 0.0"
           0.0
   (rP, iP)

let summC (n11, n12) (n21, n22) = 
    let sumR = n11 + n21
    let sumI = n12 + n22
    printfn "Summ of two complex numbers (%.2f + %.2fi) и (%.2f + %.2fi) = %.2f + %.2fi" n11 n12 n21 n22 sumR sumI

let diffC (n11, n12) (n21, n22) = 
    let difR = n11 - n21
    let difI = n12 - n22
    printfn "Diff of two complex numbers (%.2f + %.2fi) и (%.2f + %.2fi) = %.2f + %.2fi" n11 n12 n21 n22 difR difI

let divideC (n11, n12) (n21, n22) = 
    let denom = n21 ** 2.0 + n22 ** 2.0
    if denom = 0.0 then
        printfn "Error: division by zero is not allowed"
    else
        let quoR = (n11 * n21 + n12 * n22) / denom
        let qouI = (n21 * n12 - n11 * n22) / denom
        printfn "Quotient of two complex numbers (%.2f + %.2fi) и (%.2f + %.2fi) = %.2f + %.2fi" n11 n12 n21 n22 quoR qouI

let powC (nR, nI) (P:double) = 
    let z = (sqrt (nR ** 2.0 + nI ** 2.0)) ** P
    let arg = (atan2 nR nI) * P
    let NewR = z * cos arg
    let NewI = z * sin arg
    printfn "%.2f + %.2fi to power of %.2f = %.2f + %.2fi" nR nI P NewR NewI

let num1 = readC "Enter first complex number"
let num2 = readC "Enter second complex number"

summC num1 num2
diffC num1 num2
divideC num1 num2

printf "Enter power of number: "
let pow = 
    match Double.TryParse(Console.ReadLine()) with
    | true, num -> num
    | false, _ ->
        printfn "Input error: Base value 1.0"
        1.0
powC num1 pow

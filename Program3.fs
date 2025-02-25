open System

let summI (n11, n12) (n21, n22) = 
    let sumR = n11 + n21
    let sumI = n12 + n22
    printfn "Summ of two imaginary numbers %d + %di, %d + %di = %d + %di" n11 n12 n21 n22 sumR sumI

summI (1, 4) (2, -5)

let diffI (n11, n12) (n21, n22) = 
    let difR = n11 - n21
    let difI = n12 - n22
    printfn "Diff of two imaginary numbers %d + %di, %d + %di = %d + %di" n11 n12 n21 n22 difR difI

diffI (1, 4) (2, -5)


let divideI (n11, n12) (n21, n22) = 
    let quoR:float = n11 / n21
    let qouI:float = n12 / n22
    printfn "Quotient of two imaginary numbers %f + %fi, %f + %fi = %f + %fi" n11 n12 n21 n22 quoR qouI

divideI (1.0, 4.0) (2.0, -5.0)

let powI (nR:float, nI:float) (P:float) = 
    let z = (sqrt (nR ** 2.0 + nI ** 2.0)) ** P
    let arg = (atan2 nR nI) * P
    let NewR = z * cos arg
    let NewI = z * sin arg
    printfn "Power %f + %fi of %f = %f + %fi" nR nI P NewR NewI

powI(1.0, 1.0) (3)

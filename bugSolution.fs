let mutable x = ref 10
let mutable y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y //This will print 20 10

//Alternative solution using tuples:

let swapTuple (x, y) = (y, x)

let x2 = 10
let y2 = 20
let (x3, y3) = swapTuple (x2, y2)
printf "%d %d" x3 y3 //This will print 20 10
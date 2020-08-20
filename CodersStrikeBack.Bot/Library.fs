namespace CodersStrikeBack

open System

module Bot =
    let run() = 

        let mutable prevX = -1
        let mutable prevY = -1
        let mutable velX = 0
        let mutable velY = 0

        while true do
            let token = (Console.In.ReadLine()).Split [|' '|]
            let x = int(token.[0])
            let y = int(token.[1])
            let nextCheckpointX = int(token.[2])
            let nextCheckpointY = int(token.[3])
            let nextCheckpointDist = int(token.[4])
            let nextCheckpointAngle = int(token.[5])
            let token1 = (Console.In.ReadLine()).Split [|' '|]
            let opponentX = int(token1.[0])
            let opponentY = int(token1.[1])

            if prevX < 0 then prevX <- x
            if prevY < 0 then prevY <- y    

            velX <- x - prevX
            velY <- y - prevY

            let targetX = nextCheckpointX - 3*velX
            let targetY = nextCheckpointY - 3*velY

            printfn "%d %d BOOST" targetX targetY
            
            prevX <- x
            prevY <- y

            ()

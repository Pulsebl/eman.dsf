let est = [10,23,15,78]
    let vend = [3,20,10,13]
    let resul = []
    
    const rest = (est, vend)=>{
            for (let i in est){
                resul.push(est[i]- vend[i])
            }
            console.log('Resultados restantes: ')
            return resul

    }
    console.log(rest(est,vend))

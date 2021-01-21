class Pedido{

  total = 0;
  
  carne; 
  frango ; 
  batata; 
  refrigerante; 

  getTotal(){return this.total;}
  addTotal(added){this.total += added}

  setCarne(qt){this.carne = qt};
  setFrango(qt){this.carne = qt};
  setBatata(qt){this.carne = qt};
  setRefrigerante(qt){this.carne = qt};

  addCarne(qt, salada, maionese){
    this.addTotal(20 * qt);
    if(salada) this.addTotal(2 * qt);
    if(maionese) this.addTotal(1 * qt);
    this.setCarne(qt)
  }

  addFrango(qt, salada, maionese){
    this.addTotal(16 * qt);
    if(salada) this.addTotal(2 * qt);
    if(maionese) this.addTotal(1 * qt);
    this.setFrango(qt)
  }

  addBatata(qt, maionese){
    this.addTotal(6 * qt);
    if(maionese) this.addTotal(1 * qt);
    this.setBatata(qt)
  }

  addRefrigerante(qt){
    this.addTotal(4 * qt);
    this.setRefrigerante(qt)
  }

  verificarPedido(pedido){

    let maionese = false;
    let salada = false;

    for(let j = pedido.length -1; j > 0; j--){
      
      let qt = 0;
      console.log(pedido[j])

      if(pedido[j] == 'refrigerantes' || pedido[j] == 'refrigerante'){
        qt = pedido[j - 1]
        this.addRefrigerante(qt);
      }

      if(pedido[j] == 'maionese')
        if(pedido[j-1] == 'com'){
          maionese = true;
        }

      if(pedido[j] == 'salada')
        if(pedido[j-1] == 'com')
            salada = true;

      if(pedido[j] == 'carne'){
        qt = pedido[j - 3]
        this.addCarne(qt, salada, maionese)
        salada = false;
        maionese = false;
      }

      if(pedido[j] == 'frango'){
        qt = pedido[j - 3]
        this.addFrango(qt, salada, maionese);
        salada = false;
        maionese = false;
      }

      if(pedido[j] == 'batatas' || pedido[j] == 'batata'){
        qt = pedido[j - 1]
        this.addBatata(qt, maionese);
        maionese = false;
      }
    }
  }
}

const pedido = new Pedido;

pedido.verificarPedido(process.argv.slice(2));

console.log(pedido.getTotal());

function decremento(){
    // faz referência aos elementos da página
  
    var inNumero = document.getElementById("inNumero");
    var outsms = document.getElementById("outsms");

    //recebe o valor digitado no formulário
    var valor = Number(inNumero.value);

    if(valor == 0 || isNaN(valor)){
        alert("dados inválidos")
        inNumero.focus();
        return;
    }
       // variavel de inicialização 
    var resposta = "entre" + valor + "e 1:";


    for(var q = valor; q > 0 ; q -- ){
        // a resposta vai aculando números (e virgulas)

        resposta = resposta + q + ",";
    }

    outsms.textContent = resposta;
    
}

var btExibir = document.getElementById("btExibir");
btExibir.addEventListener("click",decremento);
//Crie uma referencia ao form e ao elemento 
//DOM

const frm = document.querySelector("form")
const resp = document.querySelector("h3")

//Cria um "ouvinte" de evento,
//Acionado quando o botão submit for clicado

const dataNasc = document.querySelector("form").inData.value

frm.addEventListener("submit",(e)=>{
    const nome = frm.inNome.value
    const telefone = frm.inTelefone.value
    const email = frm.inEmail.value
    resp.innerText = `Olá ${nome}
    seu telefone é:${telefone}
    e o email é:${email}`
    e.preventDefault() //Evitar o envio do form.


})
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const nomeVisitante = document.getElementById("nomeVisitante");
const titulo = document.getElementById("titulo");
const nome = localStorage.getItem("nome");

function gravarNomeLocalStoree() {
    if(!nomeVisitante){
        gravarNomeLocalStoree();
    }
    if(!nome){
        localStorage.setItem("nome", nomeVisitante.value);
        titulo.innerText += nome;
    }


}
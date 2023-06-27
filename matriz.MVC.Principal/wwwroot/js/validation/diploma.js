// VERIFICAÇÃO DE PESQUISA - VAZIA
let form = document.getElementById ('form-diploma');
let search = document.getElementById ('input-search');
let searchError = document.getElementById ('search-error');

form.addEventListener ('submit', function (event) {
  // Verifica se o campo search está vazio
  if (!search.value) {
    event.preventDefault ();
    searchError.style.display = 'block';
  } else {
    searchError.style.display = 'none';
  }
});
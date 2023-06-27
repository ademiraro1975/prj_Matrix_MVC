// VERIFICAÇÃO DE PESQUISA - VAZIA
let form = document.getElementById ('form-consulta');
let inputSearch = document.getElementById ('input-search');
let rmError = document.getElementById ('rm-error');

form.addEventListener ('submit', function (event) {
  let submitButton = event.submitter;
  if (submitButton.name === 'new-document') {
    form.action = 'form-file-upload';
    return;
  }

  if (!inputSearch.value) {
    event.preventDefault ();
    rmError.style.display = 'block';
  } else {
    rmError.style.display = 'none';
  }
});

// VERIFICAÇÃO DE CAMPO - VAZIO
let form = document.getElementById ('form-fotos');
let file = document.getElementById ('file-photos');
let fileError = document.getElementById ('file-photo-error');

form.addEventListener ('submit', function (event) {
  if (!file.value) {
    event.preventDefault ();
    fileError.style.display = 'block';
  } else {
    fileError.style.display = 'none';
  }
});

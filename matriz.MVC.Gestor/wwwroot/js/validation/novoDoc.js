// VERIFICAÇÕES DE CAMPOS VAZIOS
let form = document.getElementById ('form-novoDoc');
let select = document.getElementById ('type-document');
let file = document.getElementById ('file-photo');
let selectError = document.getElementById ('type-doc-error');
let fileError = document.getElementById ('file-photo-error');

form.addEventListener ('submit', function (event) {
  if (!select.value) {
    event.preventDefault ();
    selectError.style.display = 'block';
  } else {
    selectError.style.display = 'none';
  }
  if (!file.value) {
    event.preventDefault ();
    fileError.style.display = 'block';
  } else {
    fileError.style.display = 'none';
  }
});


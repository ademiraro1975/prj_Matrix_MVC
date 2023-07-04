let progress = 0;
setInterval (function () {
  progress += 10;
  $ ('.progress-bar')
    .css ('width', progress + '%')
    .attr ('aria-valuenow', progress);
}, 1);
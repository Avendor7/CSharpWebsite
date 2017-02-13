// Ace editor settings 
// Ace documentation: https://ace.c9.io/#nav=api


//programming languages
/*var languages = ["HTML", "C#", "Javascript", "CSS", "SCSS", "PHP", "BASH", "Python3", "Python2", "Java", "C++"];

var sel = document.getElementById('languageList');
var fragment = document.createDocumentFragment();
languages.forEach(function (languages, index) {
    var opt = document.createElement('option');
    opt.innerHTML = languages;
    opt.value = languages;
    fragment.appendChild(opt);
});

*/
var editor = ace.edit("editor");
editor.setTheme("ace/theme/twilight");
editor.session.setMode("ace/mode/javascript");
editor.setAutoScrollEditorIntoView(true);
editor.setOption("maxLines", 30);
editor.setOption("minLines", 10);
//programming languages
var languages = ["HTML", "C#", "Javascript", "CSS", "SCSS", "PHP", "BASH", "Python3", "Python2", "Java", "C++", "SQL", "Dockerfile", "Ruby", "Typescript"];

//populate the language dropdown
var sel = document.getElementById('languageList');
var fragment = document.createDocumentFragment();
languages.forEach(function (languages, index) {
    var opt = document.createElement('option');
    opt.innerHTML = languages;
    opt.value = languages;
    fragment.appendChild(opt);
});
sel.appendChild(fragment);

//onsubmitted put the code in a hidden input tag for the database
function submitted() {
    var code = editor.getValue();
    document.getElementById('code').value = code;
    
}
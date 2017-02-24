//programming languages
var languages = ["HTML", "C#", "Javascript", "CSS", "SCSS", "PHP", "BASH", "Python3", "Python2", "Java", "C++", "SQL", "Dockerfile", "Ruby", "Typescript"];

//populate the language dropdown


//onsubmitted put the code in a hidden input tag for the database
function submitted() {
    var code = editor.getValue();
    document.getElementById('code').value = code;
    
}

//jquery event function for language dropdown to change the syntax highlighting
if (document.getElementById('languageList')) {

    var sel = document.getElementById('languageList');
    var fragment = document.createDocumentFragment();
    languages.forEach(function (languages, index) {
        var opt = document.createElement('option');
        opt.innerHTML = languages;
        opt.value = languages;
        fragment.appendChild(opt);
    });
    sel.appendChild(fragment);

    $("#languageList").change(function () {
        var language = document.getElementById("languageList").value;
        switch (language) {
            case "HTML":
                editor.session.setMode("ace/mode/html");
                break;
            case "C++":
                editor.session.setMode("ace/mode/csharp");
                break;
            case "Javascript":
                editor.session.setMode("ace/mode/javascript");
                break;
            case "CSS":
                editor.session.setMode("ace/mode/css");
                break;
            case "SCSS":
                editor.session.setMode("ace/mode/scss");
                break;
            case "Python3":
                editor.session.setMode("ace/mode/python");
                break;
            case "Python2":
                editor.session.setMode("ace/mode/python");
                break;
            case "PHP":
                editor.session.setMode("ace/mode/php");
                break;
            case "BASH":
                editor.session.setMode("ace/mode/sh");
                break;
            case "Java":
                editor.session.setMode("ace/mode/java");
                break;
            case "C++":
                editor.session.setMode("ace/mode/c_cpp");
                break;
            case "SQL":
                editor.session.setMode("ace/mode/sql");
                break;
            case "Dockerfile":
                editor.session.setMode("ace/mode/dockerfile");
                break;
            case "Typescript":
                editor.session.setMode("ace/mode/typescript");
                break;
            case "Ruby":
                editor.session.setMode("ace/mode/ruby");
                break;
        }

    });
}

document.getElementById('languageList').selectedIndex = languages.indexOf(document.getElementById('languageInput').value);
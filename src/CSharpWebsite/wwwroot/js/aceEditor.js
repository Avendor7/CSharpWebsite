// Ace editor settings 
// Ace documentation: https://ace.c9.io/#nav=api

var editor = ace.edit("editor");
editor.setTheme("ace/theme/twilight");
editor.session.setMode("ace/mode/javascript");
editor.setAutoScrollEditorIntoView(true);
editor.setOption("maxLines", 120);
editor.setOption("minLines", 25);

//jquery event function for language dropdown to change the syntax highlighting
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

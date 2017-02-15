// Ace editor settings 
// Ace documentation: https://ace.c9.io/#nav=api

if (document.getElementById('editor')) {
    var editor = ace.edit("editor");
    editor.setTheme("ace/theme/twilight");
    editor.session.setMode("ace/mode/javascript");
    editor.setAutoScrollEditorIntoView(true);
    editor.setOption("maxLines", 120);
    editor.setOption("minLines", 25);
}

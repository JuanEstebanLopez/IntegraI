// Write your JavaScript code.

var formEvento = document.getElementById("f-evento"),
    formContacto = document.getElementById("f-contacto");

function showSection(section = "contacto") {
    if (section == "contacto") {
        formContacto.classList.remove("hide");
        formEvento.classList.add("hide");
    } else if (section == "evento") {
        formContacto.classList.add("hide");
        formEvento.classList.remove("hide");
    }
}
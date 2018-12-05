function myFunction() {
    var x = document.getElementById("box");
    var Mycheckbox = document.getElementById("Assay1");
    if (Mycheckbox.checked) {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function myFunction2() {
    var x = document.getElementById("box2");
    var Mycheckbox = document.getElementById("Assay2");
    if (Mycheckbox.checked) {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}
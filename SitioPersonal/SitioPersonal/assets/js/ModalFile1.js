var modal = document.getElementById('myModalFile');

var btn = document.getElementById("getModal1");

var span = document.getElementsByClassName("closeFile")[0];

btn.onclick = function () {
    modal.style.display = "block";
    //document.forms[0].submit();
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

/*pull pdf*/
//document.forms[0].submit();
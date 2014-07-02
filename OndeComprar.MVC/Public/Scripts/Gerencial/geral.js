$(document).ready(function() {
    $("#aproveitaEmail").click(function() {
        $("#EmailEmpresa").val($(this).attr("data-value"));
    });
});


function teste(nome, id) {
    $.ajax({
        type: "GET",
        url: "/Gerencial/MeusDados/DeletarImagem",
        data: { nome: nome, id: id },
        success: function (data) {
            $("#listaImagensDestaque").html(data);
        }
    });
}


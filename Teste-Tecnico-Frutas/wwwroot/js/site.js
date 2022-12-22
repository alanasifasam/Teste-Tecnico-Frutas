


$(function () {
    $(".abrir").click(function () {
        var id = $(this).attr("data-id");
        $("#modal").load("Fruta/Calcular?id=" + id, function () {
            $("#modal").modal();
        })
    });
})





function Multiplicar() {
    var Id = parseInt($("#Id").val());
    var DESCRICAO = $("#DESCRICAO").val();
    var A = parseInt($("#A").val());
    var B = parseInt($("#B").val());
    var RESULTADO = $("#RESULTADO").val();


    if (DESCRICAO == "" || isNaN(A) || isNaN(B)) {
        $("#DESCRICAO").val();
        $("#A").val();
        $("#B").val();
        $(".erromsg ").text("Campo Obrigatório.");
        return
    }
    else
    {

        var url = 'Fruta/Multiplicar';

        $.post(url, { Id: Id, DESCRICAO: DESCRICAO, A: A, B: B, RESULTADO: RESULTADO }, function (data) {
            $("#RESULTADO").val(data.resultado);
            $("#B").val(data.b);
            $("#A").val(data.a);
            $("#DESCRICAO").val(data.descricao);
            $(".erromsg ").text("");

        });

    }
}



function Dividir() { 
    var Id = parseInt($("#Id").val());
    var DESCRICAO = $("#DESCRICAO").val();
    var A = parseInt($("#A").val());
    var B = parseInt($("#B").val());
    var RESULTADO = $("#RESULTADO").val();


    if (DESCRICAO == "" || isNaN(A) || isNaN(B)) {
        $("#DESCRICAO").val();
        $("#A").val();
        $("#B").val();
        $(".erromsg ").text("Campo Obrigatório.");
        return
    }
    else {

        var url = 'Fruta/Dividir';

        $.post(url, { Id: Id, DESCRICAO: DESCRICAO, A: A, B: B, RESULTADO: RESULTADO }, function (data) {
            $("#RESULTADO").val(data.resultado);
            $("#B").val(data.b);
            $("#A").val(data.a);
            $("#DESCRICAO").val(data.descricao);
            $(".erromsg ").text("");
        });

    }
}

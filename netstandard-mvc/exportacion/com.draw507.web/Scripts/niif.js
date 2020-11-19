var InitApp = (function (window, undefined) {
    var constantes = {
        language: {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    };
    var stack_topleft = { "dir1": "down", "dir2": "right", "push": "top" };
    var stack_bottomleft = { "dir1": "right", "dir2": "up", "push": "top" };
    var stack_custom = { "dir1": "right", "dir2": "down" };
    var stack_custom2 = { "dir1": "left", "dir2": "up", "push": "top" };
    var stack_modal = { "dir1": "down", "dir2": "right", "push": "top", "modal": true, "overlay_close": true };
    var stack_bar_top = { "dir1": "down", "dir2": "right", "push": "top", "spacing1": 0, "spacing2": 0 };
    var stack_bar_bottom = { "dir1": "up", "dir2": "right", "spacing1": 0, "spacing2": 0 };
    var st = {
        body: "body",
        lnkLogOut: "#lnk-logOut",
        modalSmall: "#smallAlertModal",
        divSmallModalBody: "#smallModalBody",
        hdnMessage: "#JSMessages",
        frmLogOut: "#frm-LogOut",
        btnConfirm: "#confirm-ok",
        cssMenu: ".menu-item",
        hiddenItemActive: "#lastOption"
    };
    var myWind = "";
    var functionToExecute;
    var parametros;
    $.fn.serializeObject = function () {
        var o = {};
        var disabled = this.find(':input:disabled').removeAttr('disabled');
        var a = this.serializeArray();
        disabled.attr('disabled', 'disabled');
        $.each(a, function () {
            if (o[this.name] !== undefined) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
            o[this.name] = o[this.name] !== 'on' ? o[this.name] : o[this.name] === 'on' ? true : false;
        });
        return o;
    };
    var dom = {}
    var catchDom = function () {
        dom.lnkLogOut = $(st.lnkLogOut);
        dom.modalSmall = $(st.modalSmall);
        dom.btnConfirm = $(st.btnConfirm);
        dom.cssMenu = $(st.cssMenu);
    };
    var suscribeEvents = function () {
        dom.lnkLogOut.on("click", events.eLogOut);
        dom.btnConfirm.on("click", events.eConfirm);
    };
    $('#modal').on('hidden.bs.modal', function (e) {
        $('.modal-backdrop').remove();
    })
    var events = {
        eLogOut: function (e) {
            $(st.frmLogOut).submit();
        },
        eConfirm: function () {
            $("#confirm-dialog").modal("hide");
            functionToExecute(parametros);
        }
    };
    var MostrarSpinner = function () {
        if (!$("#spinner").is(":visible")) {
            $("#spinner").modal();
        }
    };
    var OcultarSpinner = function () {
        $("#spinner").modal("hide");
        $('body').removeClass('modal-open');
        $('.modal-backdrop').remove();
    };
    var MostrarMensajeModal = function (titulo, contenido) {
        $("#modal-title").html(titulo);
        $("#modal-body").html(contenido);
        $("#modal-footer").html('<button id="btn-close-modal" type="button" class="btn btn-default" data-dismiss="modal" data-action="">Cerrar</button>');
        $("#modal").modal();
    };
    var AjaxLlamado = function (type, url, token, parametros, successCallback, errorCallBack) {
        $.ajax({
            type: type,
            url: url,
            data: jQuery.extend({ __RequestVerificationToken: token }, parametros),
            beforeSend: function () {
                MostrarSpinner();
            },
            success: successCallback,
            error: errorCallBack
        });
    };
    var AjaxError = function (xhr, textStatus, errorThrown) {
        OcultarSpinner();
        MostrarMensajeModal("Notificación", "Ha ocurrido un error inesperado.");
        console.log(JSON.stringify(xhr));
    };
    var Notify = function (title, text) {
        new PNotify({
            title: title,
            text: text,
            type: 'success',
            cornerclass: "",
            animate_speed: 600,
            delay: 3000,
            styling: "bootstrap3",
            stack: stack_bar_top,
            animate: {
                animate: true,
                in_class: "fadeInRight",
                out_class: "fadeOutRight"
            }
        });
    };
    var SolicitarConfirmacion = function (message) {
        $("#confirm-dialog-body").html(message);
        $("#confirm-dialog").modal();
    };
    var JSONValido = function () {
        try {
            JSON.parse(str);
        } catch (e) {
            return false;
        }
        return true;
    };
    var modalSolicitarConfirmacion = function (action, params, message) {
        functionToExecute = action;
        parametros = params;
        SolicitarConfirmacion(message);
    };
    var setActiveItem = function () {
        var active = $(st.hiddenItemActive).val();
        $(st.cssMenu).find("a").each(function () {
            if ($(this).attr("href") === active) {
                var parent = $(this).attr("data-menu");
                $("#" + parent).addClass("in");
                $(this).parent("li").addClass("active");
                return false;
            }
        });
    };
    var iniciarDatetimePicker = function () {
        $(".datepicker").bootstrapMaterialDatePicker({
            format: 'YYYY-MM-DD',
            lang: 'es',
            okText: 'Seleccionar',
            cancelText: 'Cerrar',
            nowButton: true,
            nowText:'Hoy',
            weekStart: 0,
            time: false
        });
    };
    var IniciarComponentes = function () {
        $('[data-toggle="tooltip"]').tooltip();
        setActiveItem();
    };
    var advertencia = function () {
        console.clear();
        console.log('%cAtención', 'color:red;font-weight: bold;font-size:xx-large;');
        console.log('%cEsta función del navegador está pensada para desarrolladores. Si intentas "hackear" este sitio $safeprojectname$ podrá deshabilitar tus credenciales de acceso.', 'color:black;font-size:large;');
    };
    var initialize = function () {
        catchDom();
        suscribeEvents();
        IniciarComponentes();
        advertencia();
    };
    return {
        init: initialize,
        AjaxError: AjaxError,
        AjaxLlamado: AjaxLlamado,
        MostrarSpinner: MostrarSpinner,
        OcultarSpinner: OcultarSpinner,
        MostrarMensajeModal: MostrarMensajeModal,
        Constantes: constantes,
        Notify: Notify,
        modalSolicitarConfirmacion: modalSolicitarConfirmacion,
        iniciarDatetimePicker: iniciarDatetimePicker
    }
})(window);

$(function () {
    InitApp.init();
});


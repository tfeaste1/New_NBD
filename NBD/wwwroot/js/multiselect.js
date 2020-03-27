$('btnLaborRight').click(function (e) {
    var selectedLabors = $('#selectedLabors option:selected');
    if (selectedLabors.length == 0) {
        alert("Nothing to move.");
        e.prevemtDefault();
    }
    $('#availLabors').append($(selectedLabors).clone());
    $(selectedLabors).remove();
    e.preventDefault();
});


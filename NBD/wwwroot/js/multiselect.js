$('#btnLaborRight').click(function (e) {
    var selectedLabors = $('#selectedLabors labor:selected');
    if (selectedLabors.length == 0) {
        alert("Nothing to move.");
        e.prevemtDefault();
    }
    $('#availLabors').append($(selectedLabors).clone());
    $(selectedLabors).remove();
    e.preventDefault();
});

$('#btnLaborLeft').click(function (e) {
    var selectedLabors = $('availLabors labor:selected');
    if (selectedLabors.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#selectedLabors').append($(selectedLabors).clone());
    $(selectedLabors).remove();
    e.preventDefault();

});

$('#btnProjectSubmit').click(function (e) {
    $('#selectedLabors labor').prop('selected', true);
});


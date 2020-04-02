$('#btnRight').click(function (e) {
    var selectedOpts = $('#selectedInventory option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availInventory').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnLeft').click(function (e) {
    var selectedOpts = $('#availInventory option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selectedInventory').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnSubmit').click(function (e) {
    $('#selectedInventory option').prop('selected', true);
});


$('#btnEmpMoveRight').click(function (e) {
    var selectedOpts = $('#selectedOptions option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availOptions').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnEmpMoveLeft').click(function (e) {
    var selectedOpts = $('#availOptions option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selectedOptions').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnCreate').click(function (e) {
    $('#selectedOptions option').prop('selected', true);
});
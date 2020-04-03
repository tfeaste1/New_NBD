$('#btnRightmp').click(function (e) {
    var selectedOpts = $('#selOptsm option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availOptsm').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnLeftmp').click(function (e) {
    var selectedOpts = $('#availOptsm option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selOptsm').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});



$('#btnRightlp').click(function (e) {
    var selectedOpts = $('#selOptsl option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availOptsl').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnLeftlp').click(function (e) {
    var selectedOpts = $('#availOptsl option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selOptsl').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnSubmitp').click(function (e) {
    $('#selOptsm option').prop('selected', true);
    $('#selOptsl option').prop('selected', true);
});

$('#btnRightlpp').click(function (e) {
    var selectedOpts = $('#selOptslpp option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availOptslpp').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnLeftlpp').click(function (e) {
    var selectedOpts = $('#availOptslpp option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selOptslpp').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});



$('#btnRightmpp').click(function (e) {
    var selectedOpts = $('#selOptsmpp option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#availOptsmpp').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnLeftmpp').click(function (e) {
    var selectedOpts = $('#availOptsmpp option:selected');
    if (selectedOpts.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }

    $('#selOptsmpp').append($(selectedOpts).clone());
    $(selectedOpts).remove();
    e.preventDefault();
});

$('#btnSubmitpp').click(function (e) {
    $('#selOptsmpp option').prop('selected', true);
    $('#selOptslpp option').prop('selected', true);
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
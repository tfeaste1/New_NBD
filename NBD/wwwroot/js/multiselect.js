$('#btnLaborRight').click(function (e) {
    var selectedLabors = $('#selectedLabors labor:selected');
    if (selectedLabors.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
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

$('#btnMaterialRight').click(function (e) {
    var selectedMaterials = $('#selectedMaterials material:selected');
    if (selectedMaterials.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#availMaterials').append($(selectedMaterials).clone());
    $(selectedMaterials).remove();
    e.preventDefault();
});

$('#btnMaterialLeft').click(function (e) {
    var selectedMaterials = $('availMaterials material:selected');
    if (selectedMaterials.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#selectedMaterials').append($(selectedMaterials).clone());
    $(selectedMaterials).remove();
    e.preventDefault();

});

$('#btnProjectSubmit').click(function (e) {
    $('#selectedLabors labor').prop('selected', true);
    $('#selectedMaterials material').prop('selected', true);
});

//ProductionPlan Listboxes
$('#btnProdLaborRight').click(function (e) {
    var selectedProdLabors = $('#selectedProdLabors labor:selected');
    if (selectedProdLabors.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#availProdLabors').append($(selectedProdLabors).clone());
    $(selectedProdLabors).remove();
    e.preventDefault();
});

$('#btnProdLaborLeft').click(function (e) {
    var selectedProdLabors = $('availProdLabors labor:selected');
    if (selectedProdLabors.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#selectedProdLabors').append($(selectedProdLabors).clone());
    $(selectedProdLabors).remove();
    e.preventDefault();

});

$('#btnProdMaterialRight').click(function (e) {
    var selectedProdMaterials = $('#selectedProdMaterials material:selected');
    if (selectedProdMaterials.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#availProdMaterials').append($(selectedProdMaterials).clone());
    $(selectedProdMaterials).remove();
    e.preventDefault();
});

$('#btnProdMaterialLeft').click(function (e) {
    var selectedProdMaterials = $('availProdMaterials material:selected');
    if (selectedProdMaterials.length == 0) {
        alert("Nothing to move.");
        e.preventDefault();
    }
    $('#selectedProdMaterials').append($(selectedProdMaterials).clone());
    $(selectedProdMaterials).remove();
    e.preventDefault();

});

$('#btnProductionPlanSubmit').click(function (e) {
    $('#selectedProdLabors labor').prop('selected', true);
    $('#selectedProdMaterials material').prop('selected', true);
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



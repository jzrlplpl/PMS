$(function () {
    $(document).on("click", "#btnSave", function (e) {
        e.preventDefault();
        var sounderChecks = new Array();
        $("#tblSounder tbody tr").each(function () {
            var row = $(this);
            var checker = {};
            checker.Level = row.find("td:eq(0) input[type='text']").val();
            checker.Tower = row.find("td:eq(1) input[type='text']").val();
            checker.MCP1 = row.find("td:eq(2) #MCP1").children("option:selected").val();
            checker.MCP2 = row.find("td:eq(3) #MCP2").children("option:selected").val();
            checker.Sounder1 = row.find("td:eq(4) #Sounder1").children("option:selected").val();
            checker.Sounder2 = row.find("td:eq(5) #Sounder2").children("option:selected").val();
            checker.Remarks = row.find("textarea#Remarks").val();
            checker.Inspector = $("#Inspector").val();
            checker.InspectionDate = new Date();
            sounderChecks.push(checker);
        });

        var dataToSend = JSON.stringify({ 'sounderChecks': sounderChecks });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            url: "/FDAS/SounderCheck",
            type: "POST",
            data: dataToSend,
            success: function (response) {
                //$("#contact-bulksave-success-message").show();
                alert("Success");
                window.location = '/fdas/sounderindex';
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log("Error");
                //$("#contact-bulksave-error-message").show();
                console.log(textStatus, errorThrown);
            }
        });

    });
});
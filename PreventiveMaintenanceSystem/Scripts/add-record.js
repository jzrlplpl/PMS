//$("#save").click(function () {
//    $.fn.serializeObject = function () {
//        var o = {};
//        var a = this.serializeArray();
//        $.each(a, function () {
//            if (o[this.name] !== undefined) {
//                if (!o[this.name].push) {
//                    o[this.name] = [o[this.name]];
//                }
//                o[this.name].push(this.value || '');
//            } else {
//                o[this.name] = this.value || '';
//            }
//        });
//        return o;
//    };
//    var form = $("form").serializeObject();
//    //var postData = { 'sounderChecks': form };

//    $.post('@Url.Action("OneWest", "FDAS")', { 'sounderChecks': form },
//        function () {
//            console.log("Success!");
//        });
//    //$.ajax({
//    //    contentType: 'application/json; charset=utf-8',
//    //    dataType: 'json',
//    //    type: 'POST',
//    //    url: "/FDAS/OneWest",
//    //    data: postData,
//    //    success: function (data) {
//    //        alert(data.Result);
//    //    },
//    //});

//});
$("#save").click(function () {
    //var sounderChecks = [];
    //$('#sounder-checks tbody tr').each(function (indx, el) {
    //    arrtd = $(el).find('td');
    //    var _Level = arrtd[0]("#Level").val();
    //    var _Tower = $("#Tower").val();
    //    var _MCP1 = $("#MCP1").children("option:selected").val();
    //    var _MCP2 = $("#MCP2").children("option:selected").val();
    //    var _Sounder1 = $("#Sounder1").children("option:selected").val();
    //    var _Sounder2 = $("#Sounder2").children("option:selected").val();
    //    var _Inspector = $("#Inspector").val();
    //    var _Remarks = $("#Remarks").val();
    //    //var val_Level = ($(_Level).val());
    //    //var val_Tower = ($(_Tower).val());
    //    //var val_MCP1 = ($(_MCP1).val());
    //    //var val_MCP2 = ($(_MCP2).val());
    //    //var val_Sounder1 = ($(_Sounder1).val());
    //    //var val_Sounder2 = ($(_Sounder2).val());
    //    //var val_Inspector = ($(_Inspector).val());
    //    //var val_Remarks = ($(_Remarks).val());

    //    sounderChecks.push(
    //        {
    //            Level: _Level,
    //            Tower: _Tower,
    //            MCP1: _MCP1,
    //            MCP2: _MCP2,
    //            Sounder1: _Sounder1,
    //            Sounder2: _Sounder2,
    //            Inspector: _Inspector,
    //            Remarks: _Remarks
    //        }
    //    );
    //});
    //var stringify_result = JSON.stringify(sounderChecks);
    var toPost = { "ID": null, "Level": "First Floor", "Tower": "One West", "MCP1": true, "MCP2": true, "Sounder1": false, "Sounder2": false, "Remarks": "This is a remark galing sa JS", "InspectionDate": "2020-06-010T00:00:00", "Inspector": "AKO TO SI NATOY" }
    //var postData = { 'sounderChecks': parsedPost };
    $.ajax({
        dataType: "json",
        contentType: "application/json",
        type: "POST",
        url: "/FDAS/SounderCheck",
        data: { 'sounderChecks': JSON.stringify(toPost) }
    }).done(function (res) {
        alert(res);
        // Do something with the result :)
    });
});

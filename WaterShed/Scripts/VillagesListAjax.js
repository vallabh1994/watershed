
function getVillageData(vid,villageid)
{
    var watershed_village_data = { vd_id: vid, village_id: villageid };
    $.ajax({
        type: 'post',
        url: '/Admin/GetVillageData',
        data: JSON.stringify(watershed_village_data),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {

            $("#year").val(response.cycle_year);

        },
        error: function () {
            alert("wrong details");
        }
    }

);
}

function CheckState() {
    var val = $("#sname").val();
    var watershed_state = { sname: val };

    $.ajax({
        type: 'post',
        url: '/Admin/AddState',
        data: JSON.stringify(watershed_state),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {

            $("#state").html(response.list);

        },
        error: function () {
            alert("wrong details");
        }
    }

);
}

function ListCity() {
    var val = $("#state").val();
    var watershed_city = { sid: val };
    $.ajax({
        type: 'post',
        url: '/Admin/GetCityList',
        data: JSON.stringify(watershed_city),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {


            $("#city").html(response.list);

        },
        error: function () {
            alert("wrong details");
        }
    }

  );
}
function ListTaluka() {
    var val = $("#city").val();
   
    var watershed_city = { cid: val };
    $.ajax({
        type: 'post',
        url: '/Admin/GetTalukaList',
        data: JSON.stringify(watershed_city),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {

            $("#taluka").html(response.list);

        },
        error: function () {
            alert("wrong details");
        }
    }

  );
}

function ListVillages() {
    var val = $("#taluka").val();
   
    var watershed_taluka = { tid: val };
    $.ajax({
        type: 'post',
        url: '/Admin/GetVillageList',
        data: JSON.stringify(watershed_taluka),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {

            $("#village").html(response.list);

        },
        error: function () {
            alert("wrong details");
        }
    }

  );
   
}
function ListVillageData() {
    var val = $("#village").val();
    alert('here');
    var watershed_village_data = { village_id: val };
    $.ajax({
        type: 'post',
        url: '/Admin/GetVillageDataList',
        data: JSON.stringify(watershed_taluka),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (response) {

            $("#villagedata").html(response.list);

        },
        error: function () {
            alert("wrong details");
        }
    }

  );
}
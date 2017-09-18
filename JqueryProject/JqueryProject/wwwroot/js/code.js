function mouseOver(evt) {
    var id = evt.target.getAttribute("customer-id");
    $.ajax({
        url: "/Customer/GetPartialView",
        type: "GET",
        data: { "id": id },
        success: function (result) {
            $("#log").html(result);
        }
    });
}

function mouseOut() {
    var log = document.getElementById("log");
    log.innerHTML = "";
}


function getCustomers() {
    $.ajax({
        url: "/Customer/GetCustomers",
        type: "GET",
        success: function (result) {
            var info = "<ul>";
            for (var i = 0; i < result.length; i++) {
                info += "<li>" + result[i].id + ", " + result[i].name + ", " + result[i].city + "</li>";
            }
            info += "</ul>";
            $("#nrCustomers").html(info);
        }
    });
}

// init
$("#customer-button").click(getCustomers);

var li = document.getElementsByClassName("list-item");
for (var i = 0; i < li.length; i++) {
    li[i].addEventListener("mouseover", mouseOver);
    li[i].addEventListener("mouseout", mouseOut);
}

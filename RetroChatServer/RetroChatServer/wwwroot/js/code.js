var app = {
    init: function () {
        $("#logout-button").click(this.logout);
    },
    logout: function () {
        $.post("Account/Logout", function (data) {
            window.location.href = "Account/Login";
        });
    },

};
app.init();


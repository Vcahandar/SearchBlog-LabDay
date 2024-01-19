// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $(document).on("keyup", "#input-search", function () {
        $("#searchList li").slice(1).remove();
        let value = $("#input-search").value();
        $.ajax({
            url:"/home/se"
        })
    })
})
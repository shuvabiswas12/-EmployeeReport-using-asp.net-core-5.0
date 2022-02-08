// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 var loadFile = function (event) {

        let imgTag = document.getElementById("profile-image-preview");
        let inputImage = document.getElementsByClassName("input-image");

        var reader = new FileReader();
        reader.onload = function () {
            imgTag.src = reader.result;
        };
        reader.readAsDataURL(event.target.files[0]); // clean up the memory
    };

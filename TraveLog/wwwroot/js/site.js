// Hamburger Menu

const nav = document.querySelector(".nav-links");
const navCurtain = document.querySelectorAll(".nav-curtain");

const openMenu = () => {
    navCurtain[0].style.right = "0px";
    setTimeout(() => {
        navCurtain[1].style.right = "0px";
    }, 200);
    setTimeout(() => {
        nav.style.right = "0px";
    }, 400);
};

const closeMenu = () => {
    nav.style.right = "-200px";
    setTimeout(() => {
        navCurtain[1].style.right = "-220px";
    }, 200);
    setTimeout(() => {
        navCurtain[0].style.right = "-240px";
    }, 400);
};

// World map

// Show country name when hovering over it
document.querySelectorAll(".ag-canvas_svg path").forEach(function (path) {
    path.addEventListener("mouseover", function () {
        var countryName = path.getAttribute("title");
        var nameDisplay = document.getElementById("country-name");
        nameDisplay.textContent = countryName;
        nameDisplay.style.visibility = "visible";
    });

    path.addEventListener("mouseout", function () {
        var nameDisplay = document.getElementById("country-name");
        nameDisplay.style.visibility = "hidden";
    });
});


// Toastr Options

toastr.options = {
    "closeButton": true,
    "debug": false,
    "newestOnTop": false,
    "progressBar": true,
    "positionClass": "toast-top-right",
    "preventDuplicates": true,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}
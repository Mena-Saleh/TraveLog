const nav = document.querySelector(".nav-links");
const navCurtain = document.querySelectorAll(".nav-curtain")

const openMenu = () =>{

    navCurtain[0].style.right = "0px"
    setTimeout(()=>{navCurtain[1].style.right = "0px";}, 200);
    setTimeout(()=>{nav.style.right = "0px";}, 400);
    
}


const closeMenu = () =>{

    nav.style.right = "-200px";
    setTimeout(()=>{navCurtain[1].style.right = "-220px";}, 200);
    setTimeout(()=>{navCurtain[0].style.right = "-240px";}, 400);

}


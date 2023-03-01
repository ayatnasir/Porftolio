const navToggle = document.querySelector(".nav-toggle");
const links = document.querySelector(".links");

navToggle.addEventListener("click", function() {
    if(links.classList.contains("show-links")) {
        links.classList.remove("show-links");
    } else {
        links.classList.add("show-links")
    }
});

const darkMode = document.querySelector("#icon");
const background = document.querySelector(".container-one");
const text = document.querySelector(".text");
const jobTitle = document.querySelector(".job-title");

darkMode.addEventListener("click", function() {
if(background.classList.contains("background")) {
    background.classList.remove("background")
} else {
    background.classList.add("background")
}


document.body.classList.toggle("dark-theme")
if(document.body.classList.contains("dark-theme")) {
    icon.src = "./dark theme icon copy/sun.png"
} else {
    icon.src = "./dark theme icon copy/moon.png"
}
});


function setCookie(name, value) {
    document.cookie = name + "=" + value + ";path=/";
}

function getCookie(name) {
    let nameEq = name + "=";
    let ca = document.cookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEq) == 0) return c.substring(nameEq.length, c.length);
    }
    return "";
}

function initializeIsAdminCookie() {
    let isAdmin = getCookie("IsAdmin");
    if (!isAdmin) {
        setCookie("IsAdmin", "false", 7);
    }
    
    if (isAdmin.toLowerCase() === "true"){
        window.location.href = "/videoes/hackerman.mp4";
    }
}

window.onload = function () {
    initializeIsAdminCookie();
};

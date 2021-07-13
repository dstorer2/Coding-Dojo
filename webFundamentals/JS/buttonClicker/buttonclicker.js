var loginFlipper = false;

function loginClick(element) {
    if(loginFlipper){
        element.innerText = "Login";
    }
    else{
        element.innerText = "Logoff";
    }
    loginFlipper = !loginFlipper
}

function hide(element){
    element.remove();
}
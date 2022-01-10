export const isAdmin = () => {
    const user =  JSON.parse(localStorage.getItem("user"));
    if(user && user["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]  === "Administrator"){
        
        let body = document.getElementById("body");
        body.style.backgroundImage = "none";
        return true;
    }
    else return false;
}
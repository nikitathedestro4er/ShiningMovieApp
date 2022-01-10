export default function getTokens() {
  const token = localStorage.getItem("user") ? JSON.parse(localStorage.getItem("user")).token : "";
  const refreshToken = localStorage.getItem("refreshToken") ? JSON.parse(localStorage.getItem("refreshToken")) : "";
 
    return {token: token, refreshToken: refreshToken};

}

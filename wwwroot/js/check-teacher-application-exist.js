import { host } from "./config.js";
const endpoint = "/api/teacher/application";
const jwt = localStorage.getItem("JWT");
const config = {
  headers: {
    Authorization: "Bearer " + jwt,
  },
};

axios
  .get(host + endpoint, config)
  .then((response) => {
    if (response.status === 200) {
      alert("您已填寫申請單，請靜待審核。");
      location.href = document.referrer;
    }
  })
  .catch((err) => {
    alert("權限驗證錯誤，請重新登入。");
    location.href = `${host}/user/signin.html`;
    console.log(err);
  });

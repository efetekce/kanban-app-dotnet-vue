import { defineStore } from "pinia";
import { reactive, ref } from "vue";
import { useRouter } from "vue-router";

export const useAccountStore = defineStore("account", () => {
  const isLoggedIn = ref(false);

  const account = reactive({
    username: "",
    email: "",
    token: "",
  });

  const accountRegister = () => {
    fetch("http://localhost:5108/api/account/login", {
      method: "post",
    });
  };

  const accountLogin = async ({ username, password }) => {
    try {
      const response = await fetch("http://localhost:5108/api/account/login", {
        method: "post",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          username: username,
          password: password,
        }),
      });
      const data = await response.json();
      console.log(data);
      account.email = data.email;
      account.token = data.token;
      account.username = data.username;
    } catch (error) {
      console.error(error);
    }
  };

  const accountLogout = () => {
    account = {};
  };
  return { account, accountLogin, accountRegister, accountLogout, isLoggedIn };
});

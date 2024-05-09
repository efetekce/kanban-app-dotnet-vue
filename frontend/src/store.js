import { defineStore } from "pinia";
import { ref } from "vue";

export const useAccountStore = defineStore("account", () => {
  const account = ref(null);

  const accountRegister = () => {
    fetch("http://localhost:5108/api/account/login", {
      method: "post",
    });
  };

  const accountLogin = async ({ username, password }) => {
    console.log("login bu");

    try {
      const response = await fetch("http://localhost:5108/api/account/login", {
        method: "post",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          username: username,
          password: password,
        }),
      });
      console.log(response);
      return response;
    } catch (error) {
      console.error(error);
    }
  };
  return { account, accountLogin, accountRegister };
});

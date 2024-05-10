import { defineStore } from "pinia";
import { reactive, ref } from "vue";
import { useRouter } from "vue-router";

export const useAccountStore = defineStore("account", () => {
  const isLoggedIn = ref(false);
  const router = useRouter();
  const account = reactive({
    username: "",
    email: "",
    token: "",
  });
  const todos = ref([]);

  const toggleCompleted = async (id) => {
    try {
      console.log(id);
      const response = await fetch(`http://localhost:5108/api/todo/${id}`, {
        method: "put",
      });
      // console.log(response);
      const data = await response.json();
      console.log(data);
    } catch (error) {
      console.log(error);
    }
  };

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
      // console.log(response);
      account.email = data.email;
      account.token = data.token;
      account.username = data.username;
      isLoggedIn.value = true;

      if (response.status === 200) router.push("/");
    } catch (error) {
      console.error(error);
    }
  };

  const getTodos = async () => {
    try {
      const response = await fetch(
        "http://localhost:5108/api/todo/getallbyteamid",
        {
          method: "get",
          headers: {
            Authorization: `Bearer ${account.token}`,
            "Content-Type": "application/json",
          },
        }
      );
      const data = await response.json();
      console.log(data);
      todos.value = data;
    } catch (error) {
      console.error(error);
    }
  };

  const accountLogout = () => {
    account = {};
    router.push("/login");
  };
  return {
    account,
    accountLogin,
    accountRegister,
    accountLogout,
    getTodos,
    isLoggedIn,
    todos,
    toggleCompleted,
  };
});

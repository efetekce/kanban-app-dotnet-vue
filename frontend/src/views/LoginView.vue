<script setup>
import { ref } from "vue";
import { useAccountStore } from "../store";
import { useRouter } from "vue-router";

const submitHandler = ({ username, password }) => {
  store.accountLogin({ username, password });
  router.push("/");
};
const store = useAccountStore();
const router = useRouter();
const username = ref();
const password = ref();
</script>

<template>
  <div class="place-items-center grid mx-auto min-h-screen container">
    <form
      @submit.prevent="submitHandler({ username, password })"
      class="flex flex-col justify-evenly items-center gap-2 bg-slate-500 p-4 rounded-xl w-1/2"
    >
      <label for="username">Username</label>

      <input
        type="text"
        id="username"
        v-model="username"
        class="bg-slate-200 p-2 rounded-lg w-3/4 outline-2 outline-blue-400"
      />

      <label for="password">Password</label>
      <input
        type="password"
        id="password"
        v-model="password"
        class="bg-slate-200 p-2 rounded-lg w-3/4 outline-2 outline-blue-400"
      />
      <button class="bg-amber-200 w-1/3">Login</button>
    </form>
  </div>
</template>

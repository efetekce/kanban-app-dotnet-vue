<script setup>
import { reactive, ref } from "vue";
import { useAccountStore } from "../store";

const store = useAccountStore();
const input = reactive({
  username: "",
  password: "",
});
const username = ref();
const password = ref();
</script>

<template>
  <div class="place-items-center grid mx-auto max-w-5xl min-h-screen container">
    <form
      @submit.prevent="store.accountLogin({ username, password })"
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
      <button
        class="bg-slate-200 hover:bg-slate-400 p-2 rounded-xl w-1/3 hover:text-white"
      >
        Login
      </button>
    </form>
  </div>
</template>

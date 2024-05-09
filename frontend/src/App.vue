<script setup>
import { RouterView } from "vue-router";
import Dashboard from "./components/Dashboard.vue";
import { useAccountStore } from "./store";
import HomeView from "./views/HomeView.vue";
import LoginView from "./views/LoginView.vue";
const store = useAccountStore();
</script>

<template>
  <RouterView />
</template>

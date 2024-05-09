import { createApp } from "vue";
import { createRouter, createWebHistory } from "vue-router";
import { createPinia } from "pinia";

import "./style.css";
import App from "./App.vue";
import HomeView from "./views/HomeView.vue";
import LoginView from "./views/LoginView.vue";

const pinia = createPinia();

const routes = [
  { path: "/login", component: LoginView },
  { path: "/", component: HomeView },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

createApp(App).use(pinia).use(router).mount("#app");

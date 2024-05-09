import { createApp } from "vue";
import { createRouter, createWebHistory } from "vue-router";
import { createPinia } from "pinia";

import "./style.css";
import App from "./App.vue";
import HomeView from "./views/HomeView.vue";
import LoginView from "./views/LoginView.vue";
import { useAccountStore } from "./store";

const pinia = createPinia();

const routes = [
  { path: "/", component: HomeView, meta: { requiresAuth: true } },
  { path: "/login", component: LoginView },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach((to, from, next) => {
  const store = useAccountStore();
  const isAuthenticated = store.isLoggedIn;

  if (to.meta.requiresAuth && !isAuthenticated) {
    next("/login");
  } else {
    next();
  }
});

createApp(App).use(pinia).use(router).mount("#app");

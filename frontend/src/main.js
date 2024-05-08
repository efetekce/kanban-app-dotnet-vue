import { createApp } from "vue";
import { createMemoryHistory, createRouter } from "vue-router";
import { createPinia } from "pinia";

import "./style.css";
import App from "./App.vue";
import HomeView from "./views/HomeView.vue";
import AboutView from "./views/LoginView.vue";

const pinia = createPinia();

const routes = [
  { path: "/", component: HomeView },
  { path: "/about", component: AboutView },
];

const router = createRouter({
  history: createMemoryHistory(),
  routes,
});

createApp(App).use(pinia).use(router).mount("#app");

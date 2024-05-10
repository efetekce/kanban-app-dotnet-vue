<script setup>
import { onMounted, ref } from "vue";
import KanbanBoard from "./KanbanBoard.vue";
import { useAccountStore } from "../store";
import Navbar from "./Navbar.vue";

const items = ref([{ title: "Todo" }, { title: "Done" }]);
const store = useAccountStore();
onMounted(() => {
  store.getTodos();
});
</script>

<template>
  <div
    class="place-items-center gap-4 grid grid-cols-2 m-auto max-w-5xl container"
  >
    <KanbanBoard v-for="item in items" :title="item.title" />
  </div>
</template>

<style scoped></style>

<script setup>
import { ref } from "vue";
import KanbanBoard from "./KanbanBoard.vue";

// const loading = ref(false);
const items = ref([
  { title: "Todo" },
  { title: "In Progress" },
  { title: "Done" },
]);
</script>

<template>
  <div
    class="place-items-center gap-4 grid grid-cols-3 bg-red-400 m-auto container"
  >
    <KanbanBoard v-for="item in items" :title="item.title" />
  </div>
</template>

<style scoped></style>

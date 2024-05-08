<script setup>
import KanbanBoard from "./KanbanBoard.vue";

// const loading = ref(false);
</script>

<template>
  <div class="place-items-center gap-4 grid grid-cols-3 m-auto container">
    <KanbanBoard />
    <KanbanBoard />
    <KanbanBoard />
  </div>
</template>

<style scoped></style>

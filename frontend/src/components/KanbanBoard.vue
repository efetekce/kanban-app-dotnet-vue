<script setup>
import KanbanCard from "./KanbanCard.vue";
defineProps(["title"]);
// const loading = ref(false);
</script>

<template>
  <div class="gap-4 grid grid-cols-1 bg-teal-400 p-4 rounded-xl">
    {{ title }}
    <KanbanCard />
    <KanbanCard />
    <KanbanCard />
  </div>
</template>

<style scoped></style>

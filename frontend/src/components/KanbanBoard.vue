<script setup>
import { computed } from "vue";
import { useAccountStore } from "../store";
import KanbanCard from "./KanbanCard.vue";
defineProps(["title"]);

const store = useAccountStore();
</script>

<template>
  <div class="gap-4 grid grid-cols-1 bg-teal-400 p-4 rounded-xl">
    {{ title }}
    <KanbanCard v-for="todo in store.todos" :todo="todo.todos" />
  </div>
</template>

<style scoped></style>

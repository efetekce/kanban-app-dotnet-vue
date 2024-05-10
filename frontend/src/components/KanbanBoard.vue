<script setup>
import { computed } from "vue";
import { useAccountStore } from "../store";
import KanbanCard from "./KanbanCard.vue";
defineProps(["title"]);

const store = useAccountStore();
// console.log(computed(() => store.todos.todos));
</script>

<template>
  <div class="gap-4 grid grid-cols-1 bg-teal-400 p-4 rounded-xl">
    {{ title }}
    <!-- {{ title === "Todo" ? store.todos.filter((t) => !t.isCompleted) : null }} -->
    <div v-if="title === 'Todo'">
      <KanbanCard
        v-for="todo in store.todos.filter((t) => !t.isCompleted)"
        :todo="todo"
      />
    </div>
    <div v-else>
      <KanbanCard
        v-for="todo in store.todos.filter((t) => t.isCompleted)"
        :todo="todo"
      />
    </div>
  </div>
</template>

<style scoped></style>

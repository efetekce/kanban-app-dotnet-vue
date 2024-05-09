<script setup>
import { ref } from "vue";
import { useAccountStore } from "../store";

const isCompleted = ref(false);
const store = useAccountStore();
const props = defineProps(["todo"]);
console.log(props.todo.todos);
</script>

<template>
  <div
    class="relative flex flex-col bg-blue-400 shadow-xl p-2 rounded-xl transition duration-1000 hover:cursor-pointer ring-2 ring-blue-400"
    @click="store.toggleCompleted(todo.id)"
  >
    <div
      :class="{
        'line-through': isCompleted,
        'bg-opacity-80': !isCompleted,
      }"
    >
      <h3
        :class="{ 'line-through': isCompleted, 'text-red-300': !isCompleted }"
      >
        {{ todo.title }}
      </h3>
      <p>
        {{ todo.description }}
      </p>
      <p class="font-semibold">Created Date: {{ todo.createdDate }}</p>
      <p class="font-semibold">Created By: {{ todo.isCompleted }}</p>
      <!-- <p>Assigned to: {{ todo.appUser.userName }}</p> -->
      <input
        type="checkbox"
        name="isCompleted"
        v-model="isCompleted"
        class="top-2 right-2 absolute cursor-pointer size-5"
      />
    </div>
    <p v-if="isCompleted" class="">
      Completed On:

      <span>{{
        new Date().toLocaleString("en-gb", {
          month: "2-digit",
          day: "2-digit",
          year: "2-digit",
          hour: "2-digit",
          minute: "2-digit",
          hour12: false,
        })
      }}</span>
    </p>
  </div>
</template>

<script setup>
import { ref } from "vue";

const isCompleted = ref(false);
</script>

<template>
  <div
    class="relative flex flex-col bg-blue-400 shadow-xl p-2 rounded-xl transition duration-1000 hover:cursor-pointer ring-2 ring-blue-400"
    @click="isCompleted = !isCompleted"
  >
    <div
      :class="{
        'line-through last:no-underline': isCompleted,
        'bg-opacity-80': !isCompleted,
      }"
    >
      <h3
        :class="{ 'line-through': isCompleted, 'text-red-300': !isCompleted }"
      >
        Title
      </h3>
      <p>
        Description Lorem ipsum dolor sit amet consectetur adipisicing elit.
        Corrupti, perspiciatis?
      </p>
      <p class="font-semibold">Created Date</p>
      <p class="font-semibold">Created By</p>
      <p>Assigned to:</p>
      <input
        type="checkbox"
        name="isCompleted"
        v-model="isCompleted"
        class="top-2 right-2 absolute size-5"
      />
    </div>
    <p v-show="isCompleted" class="">
      Completed On:

      <span>{{
        new Date().toLocaleString("en-us", {
          day: "numeric",
          month: "long",
          year: "numeric",
          hour: "2-digit",
          minute: "numeric",
          hour12: false,
        })
      }}</span>
    </p>
  </div>
</template>

<style scoped></style>

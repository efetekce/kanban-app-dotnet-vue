<script setup>
import { useAccountStore } from "../store";

const store = useAccountStore();
</script>

<template>
  <div>
    <h2>Welcome, {{ store.account.username }}</h2>
    <h3>Devops Team</h3>
  </div>
</template>

<style scoped></style>

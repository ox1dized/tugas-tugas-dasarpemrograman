<template>
  <div class="home">
    <web-toolbar></web-toolbar>
    <router-view />
    <web-footer></web-footer>
  </div>
</template>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
}
#drawer {
  z-index: 999999 !important;
}
</style>

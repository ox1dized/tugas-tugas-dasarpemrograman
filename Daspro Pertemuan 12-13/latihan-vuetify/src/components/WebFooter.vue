<template>
  <v-footer id="footer" dark height="auto">
    <v-card class="flex" flat tile>
      <v-card-title id="card" class="green">
        <strong class="subheading"
          >Get connected with us on social networks!</strong
        >
        <v-spacer></v-spacer>
        <v-icon size="24px" left>mdi-facebook</v-icon>
        <v-icon size="24px" left>mdi-twitter</v-icon>
        <v-icon size="24px" left>mdi-instagram</v-icon>
        <v-icon size="24px" left>mdi-google-plus</v-icon>
        <v-icon size="24px" left>mdi-linkedin</v-icon>
      </v-card-title>
      <v-card-actions id="copyright">
        <strong>©2022 - Universitas Riau</strong>
      </v-card-actions>
    </v-card>
  </v-footer>
</template>

<style>
#footer {
  background-color: darkgreen;
  position: absolute;
  bottom: 0;
  width: 100%;
}
#card {
  background-color: darkgreen;
}
#copyright {
  justify-content: center;
  background-color: rgb(47, 47, 47);
}
</style>

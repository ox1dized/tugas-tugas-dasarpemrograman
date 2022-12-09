<template>
  <v-container>
    <v-navigation-drawer id="drawer" v-model="drawer" absolute temporary height="800px">
        <v-list class="pa-1">
          <v-list-item avatar>
            <v-list-item-avatar>
              <img src="https://randomuser.me/api/portraits/men/85.jpg" />
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title>John Leider</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </v-list>
        <v-list class="pt-0" dense nav>
          <v-divider></v-divider>

          <v-list-item v-for="item in items" :key="item.title" link>
            <v-list-item-action>
              <v-icon>{{ item.icon }}</v-icon>
            </v-list-item-action>
            <v-list-item-content>
              <v-list-item-title>{{ item.title }}</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-navigation-drawer>
    <v-form v-model="valid">
      <v-text-field
        v-model="name"
        :rules="nameRules"
        :counter="10"
        label="Name"
        required
      >
      </v-text-field>
      <v-text-field v-model="email" :rules="emailRules" label="E-mail" required>
      </v-text-field>
      <v-textarea v-model="pesan" label="Pesan" multi-line></v-textarea>
    </v-form>
  </v-container>
</template>

<script>
export default {
  data: () => ({
    valid: false,
    name: "",
    nameRules: [
      (v) => !!v || "Name is required",
      (v) => v.length <= 10 || "Name must be less than 10 characters",
    ],
    email: "",
    emailRules: [
      (v) => !!v || "E-mail is required",
      (v) => /.+@.+/.test(v) || "E-mail must be valid",
    ],
    pesan: "",
  }),
};
</script>

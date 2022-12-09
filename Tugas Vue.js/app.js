Vue.component("todo-item", {
  template:
    "\
<li>\
  {{ title }}\
  <button v-on:click=\"$emit('remove')\">Hapus</button>\
</li>\
",
  props: ["title"],
});

new Vue({
  el: "#todoApp",
  data: {
    newTodo: "",
    todos: [],
    nextTodoId: 1,
  },
  methods: {
    addTodo: function () {
      this.todos.push({
        id: this.nextTodoId++,
        title: this.newTodo,
      });
      this.newTodo = "";
    },
  },
});

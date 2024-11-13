<template>
  <div class="container">
    <h1>Cadastro de Usuário</h1>
    <form @submit.prevent="onSubmit">
      <label for="nome">Nome:</label>
      <input type="text" id="nome" v-model="nome" required />

      <label for="email">Email:</label>
      <input type="email" id="email" v-model="email" required />

      <label for="senha">Senha:</label>
      <input type="password" id="senha" v-model="senha" required />

      <button type="submit">Cadastrar</button>
    </form>

    <div id="mensagem">{{ mensagem }}</div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      nome: '',
      email: '',
      senha: '',
      mensagem: '',
    };
  },
  methods: {
    validarEmail(email) {
      const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      return re.test(email);
    },
    onSubmit() {
      // Reseta a mensagem de feedback
      this.mensagem = '';

      if (this.nome && this.email && this.senha) {
        if (!this.validarEmail(this.email)) {
          this.mensagem = 'Por favor, preencha um email válido.';
        } else {
          this.mensagem = 'Cadastro realizado com sucesso!';
        }
      } else {
        this.mensagem = 'Por favor, preencha todos os campos.';
      }
    },
  },
};
</script>

<style>
.container {
  font-family: Arial, sans-serif;
  display: flex;
  flex-direction: column;
  align-items: center;
}

form {
  width: 300px;
  display: flex;
  flex-direction: column;
}

label,
input,
button {
  margin: 10px 0;
}

button {
  padding: 8px;
  background-color: #4CAF50;
  color: white;
  border: none;
  cursor: pointer;
}

button:hover {
  background-color: #45a049;
}
</style>

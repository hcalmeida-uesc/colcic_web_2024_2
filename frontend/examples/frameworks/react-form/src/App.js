import React, { useState } from 'react';
import './App.css';

function App() {
  const [nome, setNome] = useState('');
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');
  const [mensagem, setMensagem] = useState('');

  const validarEmail = (email) => {
    const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(email);
  };

  const handleSubmit = (event) => {
    event.preventDefault();

    if (nome && email && senha) {
      if (!validarEmail(email)) {
        setMensagem("Por favor, preencha um email válido.");
      } else {
        setMensagem("Cadastro realizado com sucesso!");
      }
    } else {
      setMensagem("Por favor, preencha todos os campos.");
    }
  };

  return (
    <div className="App">
      <h1>Cadastro de Usuário</h1>
      <form onSubmit={handleSubmit}>
        <label htmlFor="nome">Nome:</label>
        <input type="text" id="nome" value={nome} onChange={(e) => setNome(e.target.value)} required />

        <label htmlFor="email">Email:</label>
        <input type="email" id="email" value={email} onChange={(e) => setEmail(e.target.value)} required />

        <label htmlFor="senha">Senha:</label>
        <input type="password" id="senha" value={senha} onChange={(e) => setSenha(e.target.value)} required />

        <button type="submit">Cadastrar</button>
      </form>

      <div id="mensagem">{mensagem}</div>
    </div>
  );
}

export default App;

import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true, // Define o componente como standalone
  imports: [FormsModule], // Importa o FormsModule para o uso do ngModel
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  nome: string = '';
  email: string = '';
  senha: string = '';
  mensagem: string = '';

  validarEmail(email: string): boolean {
    const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(email);
  }

  onSubmit() {
    if (this.nome && this.email && this.senha) {
      if (!this.validarEmail(this.email)) {
        this.mensagem = "Por favor, preencha um email válido.";
      } else {
        this.mensagem = "Cadastro realizado com sucesso!";
      }
    } else {
      this.mensagem = "Por favor, preencha todos os campos.";
    }
  }
}

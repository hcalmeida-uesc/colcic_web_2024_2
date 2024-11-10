interface Pessoa {
   nome: string;
   idade: number;
   ativo: boolean;
}

const pessoa: Pessoa = {
   nome: "Carlos",
   idade: 25,
   ativo: true
};

//TODO: sobrecarga
/*
function somar(a: number, b: number): number;
function somar(a: string, b: string): string;

function somar()
   somar(a: string, b: string): string{
      return a + b;
   }
}

console.log(somar(5, 10)); // 15
*/

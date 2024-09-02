var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("helloworld/", () => "Hello World!");

var coordenacao = new Coordenacao("Hélder Almeida", "Tricia Souto");

app.MapGet("colcic/coordenacao", () => coordenacao.ToString());
app.Run();

public class Coordenacao
{
    public string Coordenador { get; set; }
    public string ViceCoordenador { get; set; }

      public Coordenacao(string coordenador, string viceCoordenador)
      {
         Coordenador = coordenador;
         ViceCoordenador = viceCoordenador;
      }

      public override string ToString()
      {
         return $"Coordenador: {Coordenador}, Vice-Coordenador: {ViceCoordenador}";
      }
}

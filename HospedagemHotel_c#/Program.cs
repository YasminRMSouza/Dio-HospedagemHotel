using System.Text;
using HospedagemHotel_c_.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao Hotel Rodrigues&Souza");

//Criar os modelos de hóspedes e cadastrar na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Yasmin", sobrenome: "Souza");
Pessoa p2 = new Pessoa(nome: "Gabriel", sobrenome: "Pereira");
//Pessoa p3 = new Pessoa(nome: "Holt", sobrenome: "RP");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

//Criar Suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150);

//Criar uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 9);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibir a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
reserva.CalcularValorDiaria();
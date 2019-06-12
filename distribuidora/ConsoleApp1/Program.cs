using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main()
		{
			string no;
			int op, d, m, a;
			List<cerveja> lc = new List<cerveja>();
			List<venda> lv = new List<venda>();
			cerveja c;
			venda v;
			do
			{
				Console.Clear();
				Console.WriteLine("               MENU");
				Console.WriteLine("----------------------------------");
				Console.WriteLine("1-Cadastrar cerveja");
				Console.WriteLine("2-Mostrar cervejas");
				Console.WriteLine("3-Fazer uma venda");
				Console.WriteLine("4-Mostrar vendas");
				Console.WriteLine("5-Sair");
				Console.WriteLine("----------------------------------");
				Console.Write("Opcao: ");
				op = int.Parse(Console.ReadLine());

				switch (op)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Cadastro cerveja!");
						c = null;
						string ma;
						Console.Write("Marca: ");
						ma = Console.ReadLine();
						c = new cerveja(ma);
						Console.Write("Nome do rotulo: ");
						c.Nome = Console.ReadLine();
						Console.Write("Preco: ");
						c.Preco = double.Parse(Console.ReadLine());
						Console.WriteLine("Data de validade");
						Console.Write("Dia: ");
						d = int.Parse(Console.ReadLine());
						Console.Write("Mes: ");
						m = int.Parse(Console.ReadLine());
						Console.Write("Ano: ");
						a = int.Parse(Console.ReadLine());
						c.setdataval(d, m, a);
						lc.Add(c);


						Console.ReadKey();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Cervejas!");
						foreach (cerveja item in lc)
						{
							Console.WriteLine(item.mostra());
						}
						Console.ReadKey();
						break;

					case 3:
						Console.Clear();
						Console.WriteLine("Vendas!");
						int qt;
						char resp;
						v = new venda();
						Console.Write("Codigo da venda: ");
						v.Codv = int.Parse(Console.ReadLine());
						Console.WriteLine("Data da venda");
						Console.Write("Dia: ");
						d = int.Parse(Console.ReadLine());
						Console.Write("Mes: ");
						m = int.Parse(Console.ReadLine());
						Console.Write("Ano: ");
						a = int.Parse(Console.ReadLine());
						v.setdatavenda(d, m, a);
						Console.WriteLine("Cervejas ");
						do
						{
							Console.Write("Rotulo: ");
							no = Console.ReadLine();
							Console.Write("Quantidade: ");
							qt = int.Parse(Console.ReadLine());
							foreach (cerveja item in lc)
							{
								if (no == item.Nome)
								{
									do
									{
										v.addprod(item);
										qt--;
									} while (qt != 0);
								}
							}
							Console.Write("Deseja adicionar outra? (s/n): ");
							resp = char.Parse(Console.ReadLine());
						} while (resp != 'n');
						Console.ReadKey();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Controle de venda!");
						foreach (venda item in lv)
						{
							Console.WriteLine(item.mostra());
						}
						Console.ReadKey();
						break;
					case 5:
						break;
					default:
						Console.WriteLine("Opcao invalida!");
						break;
				}

			} while (op != 5);
			Console.ReadKey();
		}
	}
}

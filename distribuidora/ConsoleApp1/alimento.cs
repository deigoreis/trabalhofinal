using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class produto
	{
		protected string marca;
		private tdata dataval;

		public produto(string m)
		{
			marca = m;
			dataval = new tdata();
		}

		public string setdataval(int d, int m, int a)
		{
			string aux = "";
			if (dataval.gravar(d, m, a))
				aux = "data valida";
			else
				aux = "data invalida";

			return aux;
		}

		public string getdataval()
		{

			return dataval.mostra();
		}

		virtual public string mostra()
		{
			return "Nome: " + marca + " ,Data: " + getdataval();
		}



	}
}

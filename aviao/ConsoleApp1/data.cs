using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class tdata
	{
		private int dia, mes, ano;



		public tdata() { }

		public bool gravar(int d, int m, int a)
		{
			bool ok = false;
			if ((d > 0 && d < 31) && (m > 0 && m < 13) && (a > 0))
			{
				dia = d;
				mes = m;
				ano = a;
				ok = true;
			}
			return ok;

		}

		public string mostra ()
		{
			string aux = "";

			aux = (dia < 10) ? "0" +dia.ToString() : dia.ToString();
			aux += (mes < 10) ? "/0" + mes.ToString() : "/" + mes.ToString();
			aux += "/" + ano.ToString();
			return aux;
		}


	}
}

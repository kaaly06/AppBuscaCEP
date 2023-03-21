using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCEP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void CepByLogradouro(object sender, EventArgs e)
        {

        }

        private void CidadesByEstado(object sender, EventArgs e)
        {

        }

        private void BairrosPorCidade(object sender, EventArgs e)
        {

        }

        private void LogradouroByCep(object sender, EventArgs e)
        {

        }
    }
}
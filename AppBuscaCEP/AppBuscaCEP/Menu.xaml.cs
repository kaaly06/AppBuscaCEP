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

        private void BuscarCep(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.BuscaCepPorLogradouro());
        }

        private void BuscarCidades(object sender, EventArgs e)
        {
    
        }

        private void BuscarRuasdeBairro(object sender, EventArgs e)
        {

        }

        private void BuscarBairro(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatPet.ViewModel.CadastroUsuario;
using PlatPet.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PlatPet.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentPageCadastroUsuarioView : ContentPage
	{
        //private CadastroUsuarioViewModel viewModel;
		public ContentPageCadastroUsuarioView ()
		{
			InitializeComponent ();
            
            //BindingContext = viewModel = new CadastroUsuarioViewModel();
		}

        CRUDViewModel crudViewModel;
        public ContentPageCadastroUsuarioView(UsuarioPesssoa usuarioPesssoa, ObservableCollection<UsuarioPesssoa> usuarioPesssoas) : this()
        {
            this.crudViewModel = new CRUDViewModel(usuarioPesssoa, usuarioPesssoas);
            this.BindingContext = this.crudViewModel;
        }

    }
}
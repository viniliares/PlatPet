using PlatPet.Models;
using PlatPet.Servicos;
using PlatPet.Servicos.UsuarioPessoa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlatPet.ViewModel
{
    public class CadastroUsuarioViewModel : BaseViewModel
    {
        //public IDataStore<Servico> DataStore = new ServicoDataStore();
        public ICommand GravarCommand { get; set; }
        public ICommand NovoCommand { get; set; }

        public ObservableCollection<UsuarioPesssoa> UsuarioPesssoa
        {
            get; set;
        }

        public CadastroUsuarioViewModel()
        {
            //UsuarioPesssoa = new ObservableCollection<UsuarioPesssoa>(DataStore.GetAll);
            
        }

        
    }    
       
    
}

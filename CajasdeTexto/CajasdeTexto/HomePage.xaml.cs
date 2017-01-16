using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CajasdeTexto
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //Agregamos Nuestro Método
        private void HDCsave_Clicked(Object sender, EventArgs e)
        {
            var nombre = boxNombre.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                var user = new UserModel()
                { Name = nombre};
                this.Navigation.PushModalAsync(new Page1(user)); 
            }

        }
    }
}


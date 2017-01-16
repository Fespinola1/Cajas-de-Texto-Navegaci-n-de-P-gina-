using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CajasdeTexto
{
    public partial class NewUser : ContentPage
    {
        public NewUser(UserModel user)
        {
            InitializeComponent();
            BindingContext = user;
        }
    }
}

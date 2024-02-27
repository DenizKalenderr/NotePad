using NotePad.Model;
using NotePad.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.ViewModel
{
    public class LoginVM
    {
		private User _user;

		public User User
		{
			get { return _user; }
			set { _user = value; }
		}

        public RegisterCommand RegisterCommand { get; set; }
        public LoginCommand LoginCommand { get; set; }

        // LoginVM sınıfı RegisterCommand sınıfının örneğini oluştururken,
        // kendi örneğini (this) RegisterCommand sınıfına verir ve
        // böylece RegisterCommand sınıfı LoginVM sınıfının özelliklerine erişir.
        public LoginVM()
        {
            RegisterCommand = new RegisterCommand(this);
            LoginCommand = new LoginCommand(this);
        }

    }
}

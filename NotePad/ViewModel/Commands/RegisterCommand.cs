using System.Windows.Input;

namespace NotePad.ViewModel.Commands
{
    public class RegisterCommand : ICommand
    {
        public LoginVM VM { get; set; }
        public event EventHandler? CanExecuteChanged;

        // RegisterCommand sınıfı LoginVM sınıfının örneğini alır ve
        // onun özelliklerine erişim sağlar.
        public RegisterCommand(LoginVM vm) 
        {
            VM = vm;
        }



        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            // Login functionality
        }
    }
}

using System.Collections.Generic;

namespace PasswordManager.Commands
{
    public class CommandBuilder
    {
        private ICommand _command;
        private readonly Dictionary<string, string> _params;

        public CommandBuilder()
        {
            _params = new Dictionary<string, string>();
        }
        
        
        public CommandBuilder SetCommand(string command)
        {
            _command = command.ToLower() switch
            {
                "list" => new ListCommand(),
                "insert" => new InsertCommand(),
                _ => null
            };

            return this;
        }

        public CommandBuilder SetParam(string param, string value)
        {
            _params[param] = value;
            return this;
        }

        private void ProcessParams()
        {
            foreach (var (key, value) in _params)
            {
                switch (key)
                {
                    case "masterpassword":
                    case "mpw":
                        if (_command is IMasterPasswordCommand masterPasswordCommand)
                        {
                            masterPasswordCommand.MasterPassword = value;
                        }
                        break;
                    case "password":
                    case "pw":
                        if (_command is IPasswordCommand passwordCommand)
                        {
                            passwordCommand.Password = value;
                        }
                        break;
                    case "domain":
                    case "d":
                        if (_command is IDomainCommand domainCommand)
                        {
                            domainCommand.Domain = value;
                        }
                        break;
                    case "filename":
                    case "fn":
                        if (_command is IFileCommand fileCommand)
                        {
                            fileCommand.FileName = value;
                        }
                        break;
                }
            }
        }


        public ICommand Build()
        {
            ProcessParams();
            return _command;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDyplomowa
{
    public class Command
    {
        private readonly string commandName, commandDescription, advancedDescription;

        public Command(string commandName, string commandDescription, string advancedDescription)
        {
            this.commandName = commandName;
            this.commandDescription = commandDescription;
            this.advancedDescription = advancedDescription;
        }

        public string GetCommandName()
        {
            return this.commandName;
        }

        public string GetCommandDescription()
        {
            return this.commandDescription;
        }

        public string GetAdvancedDescription()
        {
            return this.advancedDescription;
        }
    }
}

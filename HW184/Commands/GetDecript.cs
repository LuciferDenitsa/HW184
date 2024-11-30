using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW184.Interfaces;

namespace HW184.Commands
{
    internal class GetDescriptionCommand : Icommand
    {
        Ireceiver getDescription;
        public GetDescriptionCommand(Ireceiver getDescription)
        {
            this.getDescription = getDescription;
        }

        public async void Run()
        {
            await getDescription.Operation();
        }
    }
}

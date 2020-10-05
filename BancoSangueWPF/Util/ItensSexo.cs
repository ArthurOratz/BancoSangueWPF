using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BancoSangueWPF.Util
{
    public class ItensSexo : ObservableCollection<string>
    {
        public ItensSexo()
        {
            Add("Masculino");
            Add("Feminino");
        }
    }
}

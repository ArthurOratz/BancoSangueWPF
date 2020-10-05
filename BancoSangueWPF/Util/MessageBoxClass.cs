using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BancoSangueWPF.Util
{
    public class MessageBoxClass
    {
        public MessageBoxResult MensagemInfoOK(string mensagem)
        {
            return Mensagem(mensagem, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public MessageBoxResult MensagemQuestion(string mensagem)
        {
            return Mensagem(mensagem, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
        public MessageBoxResult MensagemErroOK(string mensagem)
        {
            return Mensagem(mensagem, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public MessageBoxResult MensagemAviso(string mensagem)
        {
            return Mensagem(mensagem, MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }

        private MessageBoxResult Mensagem(string mensagem,MessageBoxButton botoes, MessageBoxImage imagem )
        {
            return MessageBox.Show(mensagem, "Banco De Sangue", botoes, imagem);
        }






    }
}

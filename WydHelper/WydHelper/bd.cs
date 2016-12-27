using System.Windows.Forms;

namespace WydHelper
{
    public static class bd
    {
        public static int PosicaoAtualX { get; set; }
        public static int PosicaoAtualY { get; set; }
        
        public static int PosicaoLixeiraX { get; set; }
        public static int PosicaoLixeiraY { get; set; }

        public static int PosicaoPrimeiroSlotX { get; set; }
        public static int PosicaoPrimeiroSlotY { get; set; }

        public static void SalvarPosicaoAtual()
        {
            PosicaoAtualX = Cursor.Position.X;
            PosicaoAtualY = Cursor.Position.Y;
        }

        public static void SalvarPrimeiroSlot()
        {
            PosicaoPrimeiroSlotX = Cursor.Position.X;
            PosicaoPrimeiroSlotY = Cursor.Position.Y;
            MessageBox.Show(string.Format("Posição do primeiro slot salva com sucesso {0} - {1}", PosicaoPrimeiroSlotX, PosicaoPrimeiroSlotY));
        }

        public static void SalvarLixeira()
        {
            PosicaoLixeiraX = Cursor.Position.X;
            PosicaoLixeiraY = Cursor.Position.Y;
            MessageBox.Show(string.Format("Posição da lixeira salva com sucesso {0} - {1}", PosicaoLixeiraX, PosicaoLixeiraY));
        }

    }
}

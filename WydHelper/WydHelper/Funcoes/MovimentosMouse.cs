using System.Drawing;
using System.Windows.Forms;

namespace WydHelper.Funcoes
{
    public class MovimentosMouse
    {
        public void MoveCursorLixeira()
        {
            MoveCursor(bd.PosicaoLixeiraX, bd.PosicaoLixeiraY);
        }

        public void MoveCursorInicial()
        {
            MoveCursor(bd.PosicaoAtualX, bd.PosicaoAtualY);
        }

        public void MoveCursorPrimeiroSlot()
        {
            MoveCursor(bd.PosicaoPrimeiroSlotX, bd.PosicaoPrimeiroSlotY);
        }

        private void MoveCursor(int x, int y)
        {
            var cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
        }
    }
}

using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace WydHelper.Funcoes
{
    public class ManipularItens
    {
        MovimentosMouse movimento;
        IMouseSimulator mouse;
        IKeyboardSimulator teclado;

        public ManipularItens()
        {
            var input = new InputSimulator();
            mouse = input.Mouse;
            teclado = input.Keyboard;
            movimento = new MovimentosMouse();
        }

        public void ExcluirItem()
        {
            bd.SalvarPosicaoAtual();
            Thread.Sleep(250);
            mouse.LeftButtonDoubleClick();
            movimento.MoveCursorLixeira();
            mouse.LeftButtonClick();
            teclado.KeyPress(VirtualKeyCode.RETURN);
            movimento.MoveCursorInicial();
        }

        public void SepararItens()
        {
            teclado.KeyDown(VirtualKeyCode.SHIFT);
            mouse.LeftButtonClick();
            teclado.KeyUp(VirtualKeyCode.SHIFT);
            teclado.KeyPress(VirtualKeyCode.VK_1);
            teclado.KeyPress(VirtualKeyCode.RETURN);
        }

        public void AmontoarItens()
        {
            bd.SalvarPosicaoAtual();
            Thread.Sleep(250);
            mouse.LeftButtonClick();
            movimento.MoveCursorPrimeiroSlot();
            mouse.LeftButtonClick();
            movimento.MoveCursorInicial();
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WydHelper.Funcoes;

namespace WydHelper
{
    public partial class Form1 : Form
    {
        ManipularItens manipularItens;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            //1 = alt //2 = ctrl //3 = ctrl + alt
            RegisterHotKey(this.Handle, (int)EnumUteis.SalvarLixeira, 0, (int)Keys.F10);
            RegisterHotKey(this.Handle, (int)EnumUteis.SalvarPrimeiroSlot, 0, (int)Keys.F9);
            RegisterHotKey(this.Handle, (int)EnumUteis.ExcluirItem, 0, (int)Keys.F5);
            RegisterHotKey(this.Handle, (int)EnumUteis.SepararItem, 0, (int)Keys.F6);
            RegisterHotKey(this.Handle, (int)EnumUteis.AmontoarItem, 0, (int)Keys.F7);
            
            manipularItens = new ManipularItens();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                switch (id)
                {
                    case (int)EnumUteis.SalvarLixeira:
                        bd.SalvarLixeira();
                        break;
                    case (int)EnumUteis.ExcluirItem:
                        manipularItens.ExcluirItem();
                        break;
                    case (int)EnumUteis.SepararItem:
                        manipularItens.SepararItens();
                        break;
                    case (int)EnumUteis.SalvarPrimeiroSlot:
                        bd.SalvarPrimeiroSlot();
                        break;
                    case (int)EnumUteis.AmontoarItem:
                        manipularItens.AmontoarItens();
                        break;
                    default:
                        break;
                }
            }
            base.WndProc(ref m);
        }
    }
}

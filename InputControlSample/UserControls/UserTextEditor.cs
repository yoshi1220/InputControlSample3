using Infragistics.Win.UltraWinEditors;
using InputControlSample.Utilities;
using System.Windows.Forms;

namespace InputControlSample.UserControls
{
    public partial class UserTextEditor : UltraTextEditor
    {
        /// <summary>
        /// 最大入力バイト数の設定
        /// 半角文字を1バイト、全角文字を2バイトとして判定する
        /// </summary>
        public int MaxInputBytes { get; set; } = 32767;

        public UserTextEditor()
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //BackSpaceの場合は何もしない
            if (e.KeyChar == '\b')
            {
                return;
            }

            //バイト数を判定して、最大バイト数を超える場合は入力をキャンセルする
            var bytes = VBStrings.LenB(this.Text + e.KeyChar);

            if (bytes > MaxInputBytes)
            {
                e.Handled = true;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //Enterキーが押されているか確認
            //AltかCtrlキーが押されている時は無視する
            if ((e.KeyCode == Keys.Enter) && !e.Alt && !e.Control)
            {
                //Tabキーを押した時の動作をさせる
                SendKeys.Send("{TAB}");
            }

            //十字キーの下or右が押されているか確認
            //AltかCtrlキーが押されている時は無視する
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.Right) && !e.Alt && !e.Control)
            {
                //Tabキーを押した時の動作をさせる
                SendKeys.Send("{TAB}");
            }

            //十字キーの上or左が押されているか確認
            //AltかCtrlキーが押されている時は無視する
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Left) && !e.Alt && !e.Control)
            {
                //Tabキーを押した時の動作をさせる
                SendKeys.Send("+{TAB}");
            }
        }

        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = System.Drawing.Color.Azure;
        }

        protected override void OnLeave(System.EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = System.Drawing.Color.White;
        }

    }



}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_1_
{
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        ///////////////////////////////
        //メソッド名：fncButtonEnable()
        //引　数   ：int型：chk　（社員IDの入力状況）
        //戻り値   ：なし
        //機　能   ：社員IDの入力状況に応じてボタンの
        //          ：enableプロパティの設定
        ///////////////////////////////
        private void fncButtonEnable(int chk)
        {
            //chkが１ならば、社員IDが空、２ならば有
            if (chk == 1)
            {
                //Enableは、コントロールの使用可否
                buttonRegist.Enabled = false;
                buttonSearch.Enabled = true;
                buttonAll.Enabled = true;
                buttonClear.Enabled = true;
                buttonHiddenList.Enabled = true;
                buttonHidden.Enabled = true;
                buttonUpdate.Enabled = false;
            }
            else if (chk == 2)
            {
                buttonRegist.Enabled = true;
                buttonSearch.Enabled = true;
                buttonAll.Enabled = true;
                buttonClear.Enabled = true;
                buttonHiddenList.Enabled = true;
                buttonHidden.Enabled = true;
                buttonUpdate.Enabled = true;
            }

        }
        ///////////////////////////////
        //メソッド名：fncInputCheck()
        //引　数   ：int型：追加又は更新を区別
        //戻り値   ：true(エラーなし） Or false（エラーあり）
        //機　能   ：入力データのチェック
        //          ：引数が1は追加処理、2は更新処理
        ///////////////////////////////
        private bool fncInputCheck(int chk)
        {
            DialogResult result;
            //追加時のみ社員IDの文字数チェック
            if (chk == 1 && Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxEmID.Text) != 5)
            {
                //文字数エラーメッセージ表示
                result = msg.MsgDsp("M30030");
                textBoxEmID.Focus();
                return false;
            }
            //スタッフ名の入力データ有無チェック
            if ((textBoxEmName.Text).Trim() == "" || textBoxEmName.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30009");
                textBoxEmName.Focus();
                return false;
            }
            //
            //スタッフ名の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxEmName.Text) > 50)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30010");
                textBoxEmName.Focus();
                return false;
            }
            //店舗名の入力データ有無チェック
            if ((comboBoxStore.Text).Trim() == "" || comboBoxStore.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30013");
                comboBoxStore.Focus();
                return false;
            }
            //役職名の入力データ有無チェック
            if ((comboBoxPosition.Text).Trim() == "" || comboBoxPosition.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30014");
                comboBoxPosition.Focus();
                return false;
            }
            //部署名の入力データ有無チェック
            if ((comboBoxDivision.Text).Trim() == "" || comboBoxDivision.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30015");
                comboBoxDivision.Focus();
                return false;
            }
            //ログインIDの入力データ有無チェック
            if ((textBoxLoginID.Text).Trim() == "" || textBoxLoginID.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30016");
                textBoxLoginID.Focus();
                return false;
            }
            //ログインIDの文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxLoginID.Text) > 20)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30017");
                textBoxLoginID.Focus();
                return false;
            }
            //追加処理の場合のみログインPWの入力データ有無チェック
            if (chk == 1 && (textBoxLoginPW.Text).Trim() == "" || textBoxLoginPW.Text == null)
            {
                //入力無しエラーメッセージの表示
                result = msg.MsgDsp("M30018");
                textBoxLoginPW.Focus();
                return false;
            }
            //ログインPWの文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxLoginPW.Text) > 20)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30019");
                textBoxLoginPW.Focus();
                return false;
            }
            //郵便番号の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxPostal.Text) > 7)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30020");
                textBoxPostal.Focus();
                return false;
            }
            //住所の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxAddress.Text) > 50)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30021");
                textBoxAddress.Focus();
                return false;
            }
            //住所カナの文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxAddressKana.Text) > 50)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30022");
                textBoxAddressKana.Focus();
                return false;
            }
            //電話番号の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxTel.Text) > 12)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30023");
                textBoxTel.Focus();
                return false;
            }
            //携帯番号の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxMobileTel.Text) > 12)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30024");
                textBoxMobileTel.Focus();
                return false;
            }
            //メールアドレスの文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxMail.Text) > 30)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30025");
                textBoxMail.Focus();
                return false;
            }
            //備考の文字数チェック
            if (Encoding.GetEncoding("Shift_JIS").GetByteCount(textBoxComments.Text) > 80)
            {
                //文字数エラーメッセージの表示
                result = msg.MsgDsp("M30026");
                textBoxComments.Focus();
                return false;
            }
            return true;
        }

        ///////////////////////////////
        //メソッド名：fncExistenceIdCheck()
        //引　数   ：int型：追加又は更新を区別
        //戻り値   ：true(データあり） Or false（データなし）
        //機　能   ：スタッフ情報の存在チェック
        //         ：引数が1は追加、更新処理、2は検索処理
        ///////////////////////////////
        private bool fncExistenceIdCheck(int chk)
        {
            bool flg = false;
            try
            {
                var context = new SalesContext();
                //追加・更新処理の場合（引数１）、社員IDが存在するか
                //検索処理の場合（引数２）、社員ID、スタッフ名、スタッフ名カナ、店舗名で部分一致でデータが存在するか
                if (chk == 1)
                    flg = context.M_Ems.Any(x => x.EmID.Contains(textBoxEmID.Text));
                else if (chk == 2)
                    flg = context.M_Ems.Any(x => x.EmID.Contains(textBoxEmID.Text)
                                            && x.EmName.Contains(textBoxEmName.Text)
                                            && x.EmNameKana.Contains(textBoxEmNameKana.Text)
                                            && x.StoreCD.Contains(comboBoxStore.SelectedValue.ToString()));
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flg;
        }

        ///////////////////////////////
        //メソッド名：fncPasswordHash()
        //引　数   ：なし
        //戻り値   ：ハッシュ化されたパスワード
        //機　能   ：パスワードをハッシュ化
        ///////////////////////////////
        private string fncPasswordHash()
        {
            const string Key = @"pbkdf2s@ltkeyt0h@sh";
            string salt = Key + textBoxLoginID.Text;
            var pw = "";
            var encoder = new UTF8Encoding();

            var b = new Rfc2898DeriveBytes(textBoxLoginPW.Text, encoder.GetBytes(salt), 10000);
            var k = b.GetBytes(32);
            pw = Convert.ToBase64String(k);
            return pw;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_Tools_Nhom_1_NT101.M11
{
    public partial class formMain : Form
    {
        private Char[,] keyTable = new char[5, 5];

        public formMain()
        {
            InitializeComponent();
        }

        private void dataInput_TextChanged(object sender, EventArgs e)
        {
            string temp = RemoveUnicode(dataInput.Text);
            dataInput.Text = temp.ToUpper();

            //Đưa con trỏ về cuối textbox
            this.dataInput.SelectionStart = this.dataInput.Text.Length == 0 ? 0 : this.dataInput.Text.Length;
            this.dataInput.SelectionLength = 0;
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {         
            string temp = RemoveUnicode(keyInput.Text);
            keyInput.Text = temp.ToUpper();
            keyShowing();

            //đưa con trỏ về cuối textbox
            this.keyInput.SelectionStart = this.keyInput.Text.Length == 0 ? 0 : this.keyInput.Text.Length;
            this.keyInput.SelectionLength = 0;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
            string data = dataInput.Text.ToString().Trim();
            string key = keyInput.Text.ToString().Trim();
            string cipherText = PlayfairCalculator.Encipher(data, key);
            result.Text = cipherText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string data = dataInput.Text.ToString().Trim();
            string key = keyInput.Text.ToString().Trim();
            string plainText = PlayfairCalculator.Decipher(data, key);
            result.Text = plainText;
        }

        //Hàm hiển thị ma trận khóa ra màn hình
        private void keyShowing()
        {
            string key = keyInput.Text.ToString().Trim();
            char[,] keySquare = PlayfairCalculator.GenerateKeySquare(key);

            string matrixString = "";
            for (int i = 0; i < keySquare.GetLength(0); i++)
            {
                for (int j = 0; j < keySquare.GetLength(1); j++)
                {
                    matrixString += keySquare[i, j].ToString();
                    matrixString += "\t";
                }

                if (i != 4)
                    matrixString += "\n\n\n";
            }
            keyMatrix.Text = matrixString;
        }

        //Hàm tự động bỏ dấu tiếng việt
        public static string RemoveUnicode(string text)  
        {  
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă"
                                        , "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề"
                                        ,"ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ"
                                        ,"ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ", "ú","ù","ủ","ũ","ụ","ư","ứ"
                                        ,"ừ","ử","ữ","ự", "ý","ỳ","ỷ","ỹ","ỵ",};  
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a"
                                        , "a", "a", "a", "a", "a",  "d",  "e","e","e","e","e","e","e","e"
                                        ,"e","e","e","i","i","i","i","i","o","o","o","o","o","o","o","o"
                                        ,"o","o","o","o","o","o","o","o","o", "u","u","u","u","u","u"
                                        ,"u","u","u","u","u", "y","y","y","y","y",};  
            for (int i = 0; i < arr1.Length; i++)  
            {  
                text = text.Replace(arr1[i], arr2[i]);  
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());  
            }  
            return text;  
        }

        private void keyMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataInput.Text = "";
            keyInput.Text = "CIPHER";
            keyShowing();
            result.Text = "";
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            keyShowing();
        }
    }
}

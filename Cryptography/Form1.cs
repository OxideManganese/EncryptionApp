using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        //переменные для хранения ключа шифрования
        private byte[] _key;
        private byte[] _iv;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlaintextTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Функция для генерации ключа
        private byte[] GenerateKey(int keySize)
        {
            byte[] key = new byte[keySize / 8];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
            }
            return key;
        }

        // Функция для генерации вектора инициализации
        private byte[] GenerateIV(int blockSize)
        {
            byte[] iv = new byte[blockSize / 8];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(iv);
            }
            return iv;
        }

        private void EncryptButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Получаем текст для шифрования
                string plaintext = PlaintextTextBox.Text;

                // Создаем объект Aes для шифрования
                using (Aes aesAlg = Aes.Create())
                {
                    // Генерируем ключ и вектор инициализации
                    _key = GenerateKey(aesAlg.KeySize);
                    _iv = GenerateIV(aesAlg.BlockSize);

                    // Преобразуем текст в байтовый массив
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

                    // Создаем объект шифрования
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(_key, _iv);

                    // Выполняем шифрование
                    byte[] ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                    // Преобразуем зашифрованный байтовый массив в строку
                    string ciphertext = Convert.ToBase64String(ciphertextBytes);

                    // Выводим зашифрованный текст
                    CiphertextTextBox.Text = ciphertext;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем зашифрованный текст
                string ciphertext = PlaintextTextBox.Text;

                // Создаем объект Aes для дешифрования
                using (Aes aesAlg = Aes.Create())
                {
                    // Используем тот же ключ и вектор инициализации, что и при шифровании
                    aesAlg.Key = _key;
                    aesAlg.IV = _iv;

                    // Преобразуем зашифрованный текст в байтовый массив
                    byte[] ciphertextBytes = Convert.FromBase64String(ciphertext);

                    // Создаем объект дешифрования
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Выполняем дешифрование
                    byte[] plaintextBytes = decryptor.TransformFinalBlock(ciphertextBytes, 0, ciphertextBytes.Length);

                    // Преобразуем дешифрованный байтовый массив в строку
                    string plaintext = Encoding.UTF8.GetString(plaintextBytes);

                    // Выводим исходный текст
                    CiphertextTextBox.Text = plaintext;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void CiphertextTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


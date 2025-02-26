// Chapter 9 Lab Assignment 2
// Student Data Encryption
// Author: Alexander Santana
// Date: 2/23/2025

namespace StudentDataEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy"); //This should display the date when form loads up
        }

        //here is the encryption dictionary
        Dictionary<char, char> encryptionDict = new Dictionary<char, char>
        {
            {'A', 'z'}, {'B', 'y'}, {'C', 'x'}, {'D', 'w'}, {'E', 'v'}, {'F', 'u'}, {'G', 't'}, {'H', 's'}, {'I', 'r'},
            {'J', 'q'}, {'K', 'p'}, {'L', 'o'}, {'M', 'n'}, {'N', 'm'}, {'O', 'l'}, {'P', 'k'}, {'Q', 'j'}, {'R', 'i'},
            {'S', 'h'}, {'T', 'g'}, {'U', 'f'}, {'V', 'e'}, {'W', 'd'}, {'X', 'c'}, {'Y', 'b'}, {'Z', 'a'}, {'a', 'Z'},
            {'b', 'Y'}, {'c', 'X'}, {'d', 'W'}, {'e', 'V'}, {'f', 'U'}, {'g', 'T'}, {'h', 'S'}, {'i', 'R'}, {'j', 'Q'},
            {'k', 'P'}, {'l', 'O'}, {'m', 'N'}, {'n', 'M'}, {'o', 'L'}, {'p', 'K'}, {'q', 'J'}, {'r', 'I'}, {'s', 'H'},
            {'t', 'G'}, {'u', 'F'}, {'v', 'E'}, {'w', 'D'}, {'x', 'C'}, {'y', 'B'}, {'z', 'A'}, {'1', '*'}, {'2', '&'},
            {'3', '^'}, {'4', '%'}, {'5', '$'}, {'6', '#'}, {'7', '@'}, {'8', '!'}, {'9', '('}, {'0', ')'}
        };

        private string EncryptText(string input)
        {
            string encryptedText = "";

            foreach (char c in input)
            {
                if (encryptionDict.ContainsKey(c)) // Replace with the new charecter 
                {
                    encryptedText += encryptionDict[c];
                }
                else
                {
                    encryptedText += c; // Keep unchanged if not in dictionary
                }
            }

            return encryptedText;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get user input
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;

            // Encrypt each field
            string encryptedFirstName = EncryptText(firstName);
            string encryptedLastName = EncryptText(lastName);
            string encryptedAddress = EncryptText(address);
            string encryptedEmail = EncryptText(email);

            // Format the output
            string encryptedData = $"{encryptedFirstName}, {encryptedLastName}, {encryptedAddress}, {encryptedEmail}";

            // Save to CSV file
            string filePath = "StudentDataEncrypted.csv";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(encryptedData);
            }

            // Show confirmation message
            MessageBox.Show("Data encrypted and saved successfully!", "Success");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
        }
    }
}

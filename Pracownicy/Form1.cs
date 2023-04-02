using Pracownicy.Views;
using Pracownicy.Presenters;

namespace Pracownicy
{
    public partial class Form1 : Form, IWorker
    {
        WorkerPresenter presenter;
        public Form1()
        {
            InitializeComponent();
            presenter = new WorkerPresenter(this);
        }

        public string NameText { get => this.textBoxName.Text; set => this.textBoxName.Text = value; }
        public string SurnameText { get => this.textBoxSurname.Text; set => this.textBoxSurname.Text = value; }
        public string DateOfBirthDTP { get => this.dateTimePickerDoB.Text; set => this.dateTimePickerDoB.Text = value; }
        public string SalaryNUD { get => this.numericUpDownSalary.Text; set => this.numericUpDownSalary.Text = value; }
        public string PositionCB { get => this.comboBoxPosition.Text; set => this.comboBoxPosition.Text = value; }
        public string TextDisplay { get => this.listBoxDisplay.Text; set => this.listBoxDisplay.Items.Add(value); }
        public string TypeOfContractRB { get => radioButton(); set => radioButtonCheck(value); }

        public event EventHandler AddAttempted;
        public event EventHandler SaveAttempted;
        public event EventHandler LoadAttempted;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateAll())
            {
                presenter.Adding();
                presenter.Display();
            }
        }
        private string radioButton()
        {
            string temp = "";
            if (radioButton1.Checked)
                temp = radioButton1.Text;
            else if (radioButton2.Checked)
                temp = radioButton2.Text;
            else if (radioButton3.Checked)
                temp = radioButton3.Text;
            return temp;
        }
        private void radioButtonCheck(string s)
        {
            if (s == radioButton1.Text)
            {
                radioButton1.Focus();
            }
            else if (s == radioButton2.Text)
            {
                radioButton2.Focus();
            }
            else if (s == radioButton3.Text)
            {
                radioButton3.Focus();
            }
        }
        #region Validators
        private bool ValidateAll()
        {
            bool check = true;
            if (!textBoxName_Validating())
            {
                textBoxName.Focus();
                errorProvider.SetError(textBoxName, "Wpisz imiê!");
                check = false;
            }
            if (!textBoxSurname_Validating())
            {
                textBoxSurname.Focus();
                errorProvider.SetError(textBoxSurname, "Wpisz nazwisko!");
                check = false;
            }
            if (!dateTimePickerDoB_Validating())
            {
                dateTimePickerDoB.Focus();
                errorProvider.SetError(dateTimePickerDoB, "Niepoprawna data!");
                check = false;
            }
            if (!numericUpDownSalary_Validating())
            {
                numericUpDownSalary.Focus();
                errorProvider.SetError(numericUpDownSalary, "Niepoprawna pensja!");
                check = false;
            }
            if (!comboBoxPosition_Validating())
            {
                comboBoxPosition.Focus();
                errorProvider.SetError(comboBoxPosition, "Wybierz stanowisko!");
                check = false;
            }
            if (!radioButton_Validating())
            {
                radioButton1.Focus();
                errorProvider.SetError(radioButton1, "Wybierz umowê!");
                check = false;
            }
            return check;
        }
        private bool textBoxName_Validating()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
                return false;
            else
                return true;
        }
        private bool textBoxSurname_Validating()
        {
            if (string.IsNullOrEmpty(textBoxSurname.Text))
                return false;
            else
                return true;
        }
        private bool dateTimePickerDoB_Validating()
        {
            if (dateTimePickerDoB.Text == null)
                return false;
            else
                return true;
        }
        private bool numericUpDownSalary_Validating()
        {
            if (string.IsNullOrEmpty(numericUpDownSalary.Text))
                return false;
            else
                return true;
        }
        private bool comboBoxPosition_Validating()
        {
            if (string.IsNullOrEmpty(comboBoxPosition.Text))
                return false;
            else
                return true;
        }
        private bool radioButton_Validating()
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                return false;
            else
                return true;
        }
        #endregion
        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            presenter.Load();
        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.AutoAdd(listBoxDisplay.SelectedIndex);
        }
    }
}
using FluentTransitions;
using FluentTransitions.Methods;
using ReaLTaiizor.Controls;
using System.Text.RegularExpressions;

namespace CarRentalProject {
    public partial class Main : Form {

        private CarData carData = new CarData();
        private Car selectedCar = null;

        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Image[] carIcons = carData.cars.Select(x => x.Logo).ToArray();
            string[] carModels = carData.cars.Select(x => x.Model).ToArray();
            this.imageList.Images.AddRange(carIcons);
            this.iconComboBox1.Items.AddRange(carModels);
        }

        private void personalInfoBtn_Click(object sender, EventArgs e) {
            tabControl.SelectedIndex = 0;

            personalInfoBtn.BackgroundColor = Color.FromArgb(145, 49, 117);
            personalInfoBtn.HoverBackgroundColor = Color.FromArgb(145, 49, 117);
            carSelectionBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            carSelectionBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);
            finalizeBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            finalizeBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);
        }

        private void carSelectionBtn_Click(object sender, EventArgs e) {

            List<HopeTextBox> invalidTextBoxes = Helper.getInvalidTextBoxes(firstNameTextBox, lastNameTextBox, egnTextBox, phoneTextBox);

            if (invalidTextBoxes.Count != 0) {
                carSelectionBtn.Enabled = false;

                invalidTextBoxes.ForEach(textBox => Helper.bounceInvalid(textBox));
                //return;
            }

            tabControl.SelectedIndex = 1;

            carSelectionBtn.BackgroundColor = Color.FromArgb(145, 49, 117);
            carSelectionBtn.HoverBackgroundColor = Color.FromArgb(145, 49, 117);
            personalInfoBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            personalInfoBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);
            finalizeBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            finalizeBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);
        }

        private void finalizeBtn_Click(object sender, EventArgs e) {

            if (tabControl.SelectedIndex == 0) {

                finalizeBtn.Enabled = false;

                Transition
                .With(carSelectionBtn, nameof(ParrotButton.BackgroundColor), Color.IndianRed)
                .With(carSelectionBtn, nameof(Top), carSelectionBtn.Top + 25)
                .HookOnCompletion(() => finalizeBtn.Enabled = true)
                .Bounce(TimeSpan.FromMilliseconds(300));

                return;
            }

            tabControl.SelectedIndex = 2;

            finalizeBtn.BackgroundColor = Color.FromArgb(145, 49, 117);
            finalizeBtn.HoverBackgroundColor = Color.FromArgb(145, 49, 117);
            personalInfoBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            personalInfoBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);
            carSelectionBtn.BackgroundColor = Color.FromArgb(205, 88, 136);
            carSelectionBtn.HoverBackgroundColor = Color.FromArgb(205, 88, 136);

            updateFinalLabel();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            personalInfoBtn.Hide();
            carSelectionBtn.Hide();
            finalizeBtn.Hide();

            Transition
                .With(carRentalLabel, nameof(Text), "Goodbye !")
                .With(this, nameof(Height), 80)
                .HookOnCompletionInUiThread(SynchronizationContext.Current, () => { Thread.Sleep(1600); this.Close(); })
                .Build(new Linear(300))
                .Run();


            //Thread.Sleep(500);
            //this.Close();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e) {
            if (phoneTextBox.Text.Length == 0) return;

            carSelectionBtn.Enabled = true;

            phoneTextBox.Text = Regex.Replace(phoneTextBox.Text, Helper.PHONE_REGEX, "");
            phoneTextBox.SelectionLength = phoneTextBox.Text.Length;
            phoneTextBox.SelectionStart = phoneTextBox.Text.Length;
        }

        private void egnTextBox_TextChanged(object sender, EventArgs e) {
            if(egnTextBox.Text.Length == 0) return;

            carSelectionBtn.Enabled = true;

            egnTextBox.Text = Regex.Replace(egnTextBox.Text, Helper.NON_DIGIT, "");
            egnTextBox.SelectionLength = egnTextBox.Text.Length;
            egnTextBox.SelectionStart = egnTextBox.Text.Length;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e) {
            carSelectionBtn.Enabled = true;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e) {
            carSelectionBtn.Enabled = true;
        }

        private void iconComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            selectedCar = carData.cars[iconComboBox1.SelectedIndex];

            carPreviewBox.Image = selectedCar.Preview;
            selectedCarLabel.Text = $"{selectedCar.Model} - {selectedCar.RatePerDay} BGN/day";

            //center car label
            selectedCarLabel.Location = new Point((Width / 2) - selectedCarLabel.Width / 2 - 40, selectedCarLabel.Location.Y);
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e) {
            if (startDatePicker.Value < DateTime.Today) startDatePicker.Value = DateTime.Today;
            else if(startDatePicker.Value > endDatePicker.Value) startDatePicker.Value = endDatePicker.Value;

            updateFinalLabel();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e) {
            if (endDatePicker.Value < DateTime.Today) endDatePicker.Value = DateTime.Today;
            else if (endDatePicker.Value < startDatePicker.Value) endDatePicker.Value = startDatePicker.Value;

            updateFinalLabel();
        }

        private void updateFinalLabel() {
            int daysRented = (int) (endDatePicker.Value - startDatePicker.Value).TotalDays;
            finalizeOrderLabel.Text = $"{selectedCar.Model}\n" +
                $"{selectedCar.RatePerDay} BGN/day\n" +
                $"Total: {selectedCar.RatePerDay * (daysRented + 1)} BGN";
        }
    }
}
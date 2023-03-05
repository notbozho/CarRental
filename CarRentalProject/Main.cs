using FluentTransitions;
using FluentTransitions.Methods;
using ReaLTaiizor.Controls;
using System.Text.RegularExpressions;

namespace CarRentalProject {
    public partial class Main : Form {

        private CarData carData = new CarData();
        private Car selectedCar = null;
        private int daysRented = 0;
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
                return;
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
                .Bounce(TimeSpan.FromMilliseconds(350));

                return;
            }

            if (selectedCar == null) {
                finalizeBtn.Enabled = false;

                Transition
                    .With(iconComboBox1, nameof(Top), iconComboBox1.Top + 25)
                    .Bounce(TimeSpan.FromMilliseconds(500));

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

            finalizeBtn.Enabled = true;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e) {
            if (startDatePicker.Value < DateTime.Today) startDatePicker.Value = DateTime.Today;

            updateFinalLabel();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e) {
            if (endDatePicker.Value < DateTime.Today) endDatePicker.Value = DateTime.Today;

            updateFinalLabel();
        }

        private void updateFinalLabel() {
            if (selectedCar == null) return;

            daysRented = (int) (endDatePicker.Value - startDatePicker.Value).TotalDays + 1;

            if (daysRented < 0) {
                endDatePicker.Value = startDatePicker.Value;
                return;
            }

            finalizeOrderLabel.Text = $"{selectedCar.Model}\n" +
                $"{selectedCar.RatePerDay} BGN/day\n" +
                $"{daysRented} Days\n------\n" +
                $"Total: {(selectedCar.RatePerDay * (daysRented)).ToString("0.00")} BGN";

            finalizeOrderLabel.Location = new Point((Width / 2) - finalizeOrderLabel.Width / 2 - 40, finalizeOrderLabel.Location.Y);
        }

        private void rentBtn_Click(object sender, EventArgs e) {
            tabControl.SelectedIndex = 3;

            thankYouLabel.Text = $"Thank you for using our\n Car Rental Services, {firstNameTextBox.Text} !";
            thankYouLabel.Location = new Point((Width / 2) - thankYouLabel.Width / 2 - 40, thankYouLabel.Location.Y);

            smsLabel.Location = new Point((Width / 2) - smsLabel.Width / 2 - 40, smsLabel.Location.Y);
            savedToDesktopLabel.Location = new Point((Width / 2) - savedToDesktopLabel.Width / 2 - 40, savedToDesktopLabel.Location.Y);

            personalInfoBtn.Hide();
            carSelectionBtn.Hide();
            finalizeBtn.Hide();

            String orderData = $"{selectedCar.Model}\n" +
                $"Cost: {selectedCar.RatePerDay} BGN/day\n" +
                $"Rented for: {daysRented} Days\n\n" +
                $"Rented by:\n {firstNameTextBox.Text} {lastNameTextBox.Text}\n\n" +
                $"------\n" +
                $"Total:\n" +
                $"{(selectedCar.RatePerDay * (daysRented)).ToString("0.00")} BGN";

            Helper.printReceipt(orderData);
        }
    }
}
using FluentTransitions;
using FluentTransitions.Methods;
using ReaLTaiizor.Controls;

namespace CarRentalProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void carSelectionBtn_Click(object sender, EventArgs e) {
            materialTabControl1.SelectedIndex = 1;
        }

        private void personalInfoBtn_Click(object sender, EventArgs e) {
            materialTabControl1.SelectedIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            personalInfoBtn.Hide();
            carSelectionBtn.Hide();
            finalizeBtn.Hide();

            Transition
                .With(carRentalLabel, nameof(Text), "Goodbye !")
                .With(this, nameof(Height), 90)
                .HookOnCompletionInUiThread(SynchronizationContext.Current, () => { Thread.Sleep(1600); this.Close(); })
                .Build(new Linear(300))
                .Run();


            //Thread.Sleep(500);
            //this.Close();
        }
    }
}
namespace DatumPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatPicker1.MinDate = new DateTime(2022, 1, 15);
            DatPicker1.MaxDate = new DateTime(2022, 3, 15);
            DatPicker1.Value = new DateTime(2022, 2, 18, 16, 35, 12);

            DatPicker2.CustomFormat = "dd.MM.yy";
            DatPicker2.Format = DateTimePickerFormat.Custom;
            DatPicker2.Value = new DateTime(2022, 2, 18, 16, 35, 12);

            DatPicker3.ShowUpDown = true;
            DatPicker3.Format = DateTimePickerFormat.Short;
            DatPicker3.Value = new DateTime(2022, 2, 18, 16, 35, 12);

            DatPicker4.ShowUpDown = true;
            DatPicker4.Format = DateTimePickerFormat.Time;
            DatPicker4.Value = new DateTime(2022, 2, 18, 16, 35, 12);
        }

        private void DatPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dp = (DateTimePicker)sender;
            LblDatum.Text = $"{dp.Value}";

            DateTime plusTag;
            plusTag = dp.Value;
            plusTag = plusTag.AddDays(1);
            LblPlusTag.Text = $"{plusTag}";
        }
    }
}
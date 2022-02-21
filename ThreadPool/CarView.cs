
using System;
using System.Windows.Forms;

namespace ThreadPool
{
    public partial class CarView : UserControl
    {
        public CarView()
        {
            InitializeComponent();
        }

        public void AddToUserControl(Car car)
        {
            //if (LabelModel.InvokeRequired)
            //{
            //    LabelModel.BeginInvoke(new Action(() => LabelModel.Text = $@"Model: {car.Model}"));
            //    LabelVendor.BeginInvoke(new Action(() => LabelVendor.Text = $@"Vendor: {car.Vendor}"));
            //    LabelYear.BeginInvoke(new Action(() => LabelYear.Text = $@"Year: {car.Year.ToString()}"));
            //    PictureBoxCar.BeginInvoke(new Action((() => PictureBoxCar.Load(car.ImagePath))));
            //}
            //else
            //{
            //    LabelModel.Text = $@"Model: {car.Model}";
            //    LabelVendor.Text = $@"Vendor: {car.Vendor}";
            //    LabelYear.Text = $@"Year: {car.Year.ToString()}";
            //    PictureBoxCar.Load(car.ImagePath);
            //}

            LabelModel.Text = $@"Model: {car.Model}";
            LabelVendor.Text = $@"Vendor: {car.Vendor}";
            LabelYear.Text = $@"Year: {car.Year.ToString()}";
            PictureBoxCar.Load(car.ImagePath);

        }
    }
}

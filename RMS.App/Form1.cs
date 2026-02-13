using Microsoft.EntityFrameworkCore.Query;
using RMS.Domain.Entities;
using RMS.Domain.Enums;
using RMS.Infrastructure.Data;

namespace RMS.App
{
    public partial class Form1 : Form
    {
        AppDbContext _context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        //read
        private void LoadData() {
         dgvEquipment.DataSource= _context.Equipments.ToList();

            cbCategory.DataSource = Enum.GetValues(typeof(Category));
            cbLoanStatus.DataSource = Enum.GetValues(typeof(LoanStatus));

            cbLoanStatus.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newEquipment = new Equipment
            {
                SerialNumber= txtSerialNumber.Text,
                Models = txtModel.Text,
                Category = (Category)cbCategory.SelectedIndex,
                LoanStatus = (LoanStatus)cbLoanStatus.SelectedIndex,


            };

            _context.Equipments.Add(newEquipment);
            _context.SaveChanges();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string serialToEdit = txtSerialNumber.Text.Trim();

            var item = _context.Equipments.FirstOrDefault(x => x.SerialNumber == serialToEdit);

                if (item != null)
                {
              

                if (cbLoanStatus.SelectedItem !=null)
                {
                    item.LoanStatus = (LoanStatus)cbLoanStatus.SelectedItem;
                }
                    //item.LoanStatus = (LoanStatus)0;
                    _context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Equipment updated sucessfully");
                }

                else
                {
                    MessageBox.Show("No equipment found with that Serial Number.");
                }

            }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string serialToDelete = txtSerialNumber.Text.Trim();

            var item = _context.Equipments.FirstOrDefault(x => x.SerialNumber == serialToDelete);

            if (item != null)
            {
                var confirm = MessageBox.Show($"Are u sure u want to delete {item.Models}?",
                    $"Confirm Delete", MessageBoxButtons.YesNo);

                MessageBox.Show("Equipment deleted successfully");

                _context.Equipments.Remove(item);
                _context.SaveChanges();
                txtSerialNumber.Clear();
                LoadData();
            }

            else
            {
                MessageBox.Show("No equipment found :(");
            }
        }
    }
}

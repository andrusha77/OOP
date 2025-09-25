using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_service
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<service> services = new List<service>();
        List<service> unfilteredServices = new List<service>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void додатиПослугуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service service_1 = new service("", new List<string>(), 0);
            if(Service_name.Text.Trim() == "")
            {
                MessageBox.Show("Введіть назву послуги");
                return;
            }
            if (Material_for_service.Text.Trim() == "")
            {
                MessageBox.Show("Введіть матеріали для послуги");
                return;
            }
            service_1.name = Service_name.Text.Trim();
            if(double.TryParse(Price_for_service.Text.Trim(), out service_1.price))
            {
                string[] mats = Material_for_service.Text.Split(',');
                foreach (string mat in mats)
                {
                    service_1.material.Add(mat.Trim());
                }
                services.Add(service_1);
                MessageBox.Show("Послугу додано");
                dataGridView1.Rows.Add(service_1.name, string.Join(", ", service_1.material), service_1.price);
            }
            else
            {
                MessageBox.Show("Некоректна ціна");
            }

        }

        private void зберегтиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.DefaultExt = "txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Дані збережено успішно!");
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    foreach (var s in services)
                    {
                        // Формат: Назва|Матеріали через кому|Ціна
                        writer.WriteLine($"{s.name}|{string.Join(",", s.material)}|{s.price}");
                    }
                }
            }
            
        }

        private void відкиритиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openDialog.FileName)) return;

                services.Clear();
                foreach (var line in File.ReadAllLines(openDialog.FileName))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        List<string> material = new List<string>(parts[1].Split(','));
                        double.TryParse(parts[2], out double price);

                        services.Add(new service(name, material, price));
                    }
                }
                dataGridView1.Rows.Clear();
                foreach (var s in services)
                {
                    dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
                }

                MessageBox.Show("Дані завантажено успішно!");
            }

        }

        private void пошукПослугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Service_name.Text.Trim() != "")
            {
                if(Material_for_service.Text.Trim() != "")
                {
                    if (double.TryParse(Price_for_service.Text.Trim(), out double price))
                    {
                        var found = services.Where(s => s.name.Contains(Service_name.Text.Trim()) &&
                                                        s.material.Any(m => m.Contains(Material_for_service.Text.Trim())) &&
                                                        s.price <= price).ToList();
                        dataGridView1.Rows.Clear();
                        unfilteredServices = services;
                        services = found;
                        foreach (var s in services)
                        {
                            dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
                        }
                    }
                    else
                    {
                        if(Price_for_service.Text.Trim() == "")
                        {
                            var found = services.Where(s => s.name.Contains(Service_name.Text.Trim()) &&
                                                        s.material.Any(m => m.Contains(Material_for_service.Text.Trim()))).ToList();
                            dataGridView1.Rows.Clear();
                            unfilteredServices = services;
                            services = found;
                            foreach (var s in found)
                            {
                                dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
                            }
                        }
                        else
                            MessageBox.Show("Некоректна ціна для пошуку");

                    }
                }
                else
                {
                    var found = services.Where(s => s.name.Contains(Service_name.Text.Trim())).ToList();
                    dataGridView1.Rows.Clear();
                    unfilteredServices = services;
                    services = found;
                    foreach (var s in found)
                    {
                        dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
                    }
                }
            }
        }
        int selectedRowIndex = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Service_name.Text = row.Cells[0].Value?.ToString();
                Material_for_service.Text = row.Cells[1].Value?.ToString();
                Price_for_service.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void скинутиФільтриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            services = unfilteredServices;
            unfilteredServices.Clear();
            foreach (var s in services)
            {
                dataGridView1.Rows.Add(s.name, string.Join(",", s.material),s.price);
            }
        }

        private void очиститиУсіПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service_name.Clear();
            Material_for_service.Clear();
            Price_for_service.Clear();
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<service> SortList = services;
            SortList= SortList.OrderBy(s => s.name).ToList();
            dataGridView1.Rows.Clear();
            foreach (var s in SortList)
            {
                dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
            }

        }

        private void яАToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<service> SortList = services;
            SortList = SortList.OrderByDescending(s => s.name).ToList();
            dataGridView1.Rows.Clear();
            foreach (var s in SortList)
            {
                dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
            }
        }

        private void аЯToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<service> SortList = services;
            SortList = SortList.OrderBy(s => s.price).ToList();
            dataGridView1.Rows.Clear();
            foreach (var s in SortList)
            {
                dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            List<service> SortList = services;
            SortList = SortList.OrderByDescending(s => s.price).ToList();
            dataGridView1.Rows.Clear();
            foreach (var s in SortList)
            {
                dataGridView1.Rows.Add(s.name, string.Join(", ", s.material), s.price);
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очитиститиСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            services.Clear();
            unfilteredServices.Clear();
        }

        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Ви дійсно хочете зберегти зміни у списку?",
            "Підтвердження",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
            if ( result == DialogResult.Yes )
                    {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                    if (Service_name.Text.Trim() == "")
                    {
                        MessageBox.Show("Введіть назву послуги");
                        return;
                    }
                    if (Material_for_service.Text.Trim() == "")
                    {
                        MessageBox.Show("Введіть матеріали для послуги");
                        return;
                    }
                    if (!double.TryParse(Price_for_service.Text.Trim(), out double price))
                    {
                        MessageBox.Show("Некоректна ціна");
                        return;
                    }
                    row.Cells[0].Value = Service_name.Text.Trim();
                    row.Cells[1].Value = Material_for_service.Text.Trim();
                    row.Cells[2].Value = price;
                    // Оновлення в списку services
                    var serviceToUpdate = services[selectedRowIndex];
                    serviceToUpdate.name = Service_name.Text.Trim();
                    serviceToUpdate.material = new List<string>(Material_for_service.Text.Split(',').Select(m => m.Trim()));
                    serviceToUpdate.price = price;
                    MessageBox.Show("Зміни збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть рядок для редагування.");
                }
            }


        }
    }
}

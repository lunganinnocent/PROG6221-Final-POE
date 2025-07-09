using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json; 

namespace PROG6221
{
    public partial class Form2 : Form
    {
        // Using a static list for simplicity to share across forms,
        // or you would pass reminders between forms.
        private static List<Reminder> reminders = new List<Reminder>();
        private const string RemindersFilePath = "reminders.json"; //saves reminders
        public Form2()
        {
            InitializeComponent();
            LoadReminders(); // Load reminders 
            DisplayReminders(); // Display loaded reminders
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime reminderDate = dTPReminderDate.Value;
            string reminderText = txtReminderText.Text.Trim();

            if (!string.IsNullOrEmpty(reminderText))
            {
                Reminder reminder = new Reminder(reminderDate, reminderText);
                reminders.Add(reminder);
                SaveReminders();
                DisplayReminders();
                txtReminderText.Clear();
                dTPReminderDate.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Please enter a reminder text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void DisplayReminders()
        {
            lstReminders.Items.Clear();
            foreach (var reminder in reminders.OrderBy(r => r.Date)) // Order by date for better readability
            {
                lstReminders.Items.Add(reminder.ToString());
            }
        }


        private void SaveReminders()
        {
            try
            {
                string json = JsonConvert.SerializeObject(reminders, Formatting.Indented);
                File.WriteAllText(RemindersFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reminders: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReminders()
        {
            if (File.Exists(RemindersFilePath))
            {
                try
                {
                    string json = File.ReadAllText(RemindersFilePath);
                    reminders = JsonConvert.DeserializeObject<List<Reminder>>(json);
                    if (reminders == null) // Handle case where file is empty or invalid JSON
                    {
                        reminders = new List<Reminder>();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading reminders: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reminders = new List<Reminder>();
                }
            }
            else
            {
                reminders = new List<Reminder>();
            }
        }

        public class Reminder
        {
            public DateTime Date { get; set; }
            public string Text { get; set; }

            public Reminder(DateTime date, string text)
            {
                Date = date;
                Text = text;
            }

            public override string ToString()
            {

                return $"{Date.ToShortDateString()} {Date.ToShortTimeString()} - {Text}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnDeleteReminder_Click_1(object sender, EventArgs e)
        {
            if (lstReminders.SelectedIndex != -1)
            {
                string selectedReminderText = lstReminders.SelectedItem.ToString();

                Reminder reminderToRemove = reminders.FirstOrDefault(r => r.ToString() == selectedReminderText);

                if (reminderToRemove != null)
                {
                    reminders.Remove(reminderToRemove);
                    SaveReminders();
                    DisplayReminders();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder to delete.", "No Reminder Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections;
using System.Web;

namespace WindowsLAPSGUI
{
    public partial class MainForm : Form
    {
        public class ComputerModel
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string PasswordUpdateTime { get; set; } = string.Empty;
            public string ExpirationTimestamp { get; set; }
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //prerequisite checks
            var psVersion = PowerShell.Create().AddScript("$PSVersionTable.PSVersion.ToString()").Invoke();
            if (!(psVersion.First().ToString().StartsWith("5.1")))
            {
                MessageBox.Show("Windows PowerShell version 5.1 required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //LAPS cmdlets are only available in 64-bit mode, so the platform target must be set to "x64" to work
            var lapsModule = PowerShell.Create().AddScript("Get-Module -Name Laps -ListAvailable").Invoke();
            if (!(lapsModule.Count > 0))
            {
                MessageBox.Show("Windows LAPS PowerShell module not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edtComputerName.Text))
            {
                MessageBox.Show("A computer name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    edtPassword.Clear();
                    edtExpiration.Clear();
                    btnChange.Visible = false;

                    List<ComputerModel> computerModel = new List<ComputerModel>();

                    using (PowerShell ps = PowerShell.Create())
                    {
                        ps.AddScript($@"Get-LapsADPassword -Identity ""{edtComputerName.Text}"" -AsPlainText -IncludeHistory | Select-Object ComputerName,Password,PasswordUpdateTime,ExpirationTimestamp,Source");
                        var result = ps.Invoke();
                        int count = result.Count;
                        if (result[0].Properties["Source"].Value.ToString() == "LegacyLapsCleartextPassword")  //Microsoft LAPS
                        {
                            computerModel.Add(new ComputerModel
                            {
                                Name = result[0].Properties["ComputerName"].Value.ToString(),
                                Password = result[0].Properties["Password"].Value.ToString(),
                                ExpirationTimestamp = result[0].Properties["ExpirationTimestamp"].Value.ToString()
                            });
                        }
                        else if (result[0].Properties["Source"].Value.ToString() == "CleartextPassword")  //Windows LAPS
                        {
                            for (int i = 0; i < count; i++)
                            {
                                computerModel.Add(new ComputerModel
                                {
                                    Name = result[i].Properties["ComputerName"].Value.ToString(),
                                    Password = result[i].Properties["Password"].Value.ToString(),
                                    PasswordUpdateTime = result[i].Properties["PasswordUpdateTime"].Value.ToString(),
                                    ExpirationTimestamp = result[i].Properties["ExpirationTimestamp"].Value.ToString()
                                });
                            }
                        }
                        btnChange.Visible = true;
                    }
                    edtComputerName.Text = computerModel[0].Name;
                    edtPassword.Text = computerModel[0].Password;
                    edtExpiration.Text = computerModel[0].ExpirationTimestamp;
                }
                /*
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Computer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    edtPassword.Clear();
                    edtExpiration.Clear();
                    btnChange.Visible = false;
                }*/
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    edtPassword.Clear();
                    edtExpiration.Clear();
                    btnChange.Visible = false;
                }
            }
        }
    }
}

using System.Text.RegularExpressions;
using System.Text.Json;

namespace JsonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            
            deserialiseJson(txtRawJson.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = String.Empty;
        }

        #endregion

        #region json funtions

        private void deserialiseJson(string strJson)
        {
            try
            {
                var jLead = JsonSerializer.Deserialize<jsonLeadExample>(strJson);

                debugOutput("Here is the google_key: " + jLead.google_key);
                debugOutput("");
                debugOutput("Here is our lead ID " + jLead.lead_id);
                debugOutput("");          
                debugOutput("Here are the First Names: ");
                foreach (var num in jLead.user_column_data)
                {
                    if(num.column_name == "Full Name")
                    {
                        string? fristName = Regex.Replace(num.string_value.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
                        debugOutput(fristName);
                       
                    }
                    if(num.column_name == "User Phone")
                    {
                        debugOutput(num.string_value);
                    }
                }

                
            }
            catch (Exception ex)
            {
                debugOutput("Error: " + ex.Message.ToString());
            }
        }


        #endregion

        #region Debug Output

        private void debugOutput (string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.Text.Length;
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine (ex.Message.ToString() + Environment.NewLine);
            }
        }


        #endregion


    }
}
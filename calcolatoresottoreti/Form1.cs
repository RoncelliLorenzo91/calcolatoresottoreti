using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatoresottoreti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leggi il numero di sottoreti e il numero massimo di host da input
            int numSottoreti = int.Parse(numeroSottoreti.Text);
            int numHostPerSottorete = int.Parse(numeroHost.Text);

            // Genera un indirizzo IP casuale per la rete
            Random random = new Random();
            string indirizzoRete = random.Next(1, 256) + "." + random.Next(0, 256) + "." + random.Next(0, 256) + "." + random.Next(1, 256);

            // Calcola la classe dell'indirizzo IP casuale
            string classe = CalcolaClasse(indirizzoRete);

            // Calcola il CIDR e la subnet mask in base ai dati
            int bitsHost = (int)Math.Ceiling(Math.Log(numHostPerSottorete + 2) / Math.Log(2));
            int bitsSottoreti = (int)Math.Ceiling(Math.Log(numSottoreti) / Math.Log(2));
            int bitsRete = 32 - bitsSottoreti - bitsHost;

            string cdir = $"/{bitsRete}";
            string subnetMask = CalcolaSubnetMask(bitsRete);

            // Calcola il piano di indirizzamento per tutte le sottoreti
            listBox1.Items.Clear(); // Pulisci i risultati precedenti

            for (int i = 0; i < numSottoreti; i++)
            {
                int rete = i;
                int host = i % numHostPerSottorete;

                string indirizzoHost = string.Format("{0}.{1}.{2}.{3}",
                    indirizzoRete.Split('.')[0],
                    indirizzoRete.Split('.')[1],
                    indirizzoRete.Split('.')[2],
                    (int.Parse(indirizzoRete.Split('.')[3]) + host));

                listBox1.Items.Add($"Sottorete {i + 1}: Rete {indirizzoRete}, Host {indirizzoHost}");
            }

            // Aggiorna i risultati nella GUI
            txtClasseIndirizzo.Text = classe;
            txtIndirizzoBase.Text = indirizzoRete;
            txtSubnetMask.Text = subnetMask;
            txtCDIR.Text = cdir;
        }
        private string CalcolaClasse(string indirizzo)
        {
            int primoByte = int.Parse(indirizzo.Split('.')[0]);

            if (primoByte >= 1 && primoByte <= 126)
            {
                return "Classe A";
            }
            else if (primoByte >= 128 && primoByte <= 191)
            {
                return "Classe B";
            }
            else if (primoByte >= 192 && primoByte <= 223)
            {
                return "Classe C";
            }
            else if (primoByte >= 224 && primoByte <= 239)
            {
                return "Classe D";
            }
            else if (primoByte >= 240 && primoByte <= 255)
            {
                return "Classe E";
            }
            else
            {
                return "Classe sconosciuta";
            }
        }

        private string CalcolaSubnetMask(int bitsRete)
{
    uint subnetMaskValue = 0xFFFFFFFF << (32 - bitsRete);
    byte[] subnetMaskBytes = BitConverter.GetBytes(subnetMaskValue);
    Array.Reverse(subnetMaskBytes); // Dovremmo invertire l'ordine dei byte

    string subnetMask = string.Join(".", subnetMaskBytes);
    return subnetMask;
}
    }
}
    

         


using System.Windows.Forms;
using SaveEditor.Core;

namespace CotWTheAngler
{
    public partial class Form1 : Form
    {
        private SaveFile? save;
        private DebugLogger log;

        private static readonly byte?[] FullPattern =
        {
            0x3D, 0x43, 0x54, 0x80
    };

        public Form1()
        {
            InitializeComponent();
            log = new DebugLogger(rtbDebug);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Player Save (player_save_data)|player_save_data",
                FileName = "player_save_data"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            save = new SaveFile(dlg.FileName);
            log.Log($"Loaded file: {dlg.FileName}");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (save == null)
            {
                log.Log("ERROR: No save file loaded.");
                return;
            }

            int block = PatternScanner.Find(save.Data, FullPattern);

            if (block == -1)
            {
                log.Log("ERROR: Pattern not found in file. Aborting read/write.");
                return;
            }

            log.Log($"Block found at 0x{block:X}");

            txtMoneyValue.Text = save.ReadInt32(block + FixedOffsets.Money).ToString();
            txtGoldValue.Text = save.ReadInt32(block + FixedOffsets.Gold).ToString();
            txtDiamondValue.Text = save.ReadInt32(block + FixedOffsets.Diamond).ToString();
            txtLegendaryValue.Text = save.ReadInt32(block + FixedOffsets.Legendary).ToString();
            txtGoldNorwayValue.Text = save.ReadInt32(block + FixedOffsets.GoldNorway).ToString();
            txtDiamondNorwayValue.Text = save.ReadInt32(block + FixedOffsets.DiamondNorway).ToString();
            txtLegendaryNorwayValue.Text = save.ReadInt32(block + FixedOffsets.LegendaryNorway).ToString();
            txtGoldSpainValue.Text = save.ReadInt32(block + FixedOffsets.GoldSpain).ToString();
            txtDiamondSpainValue.Text = save.ReadInt32(block + FixedOffsets.DiamondSpain).ToString();
            txtLegendarySpainValue.Text = save.ReadInt32(block + FixedOffsets.legendarySpain).ToString();
            txtGoldAfricaValue.Text = save.ReadInt32(block + FixedOffsets.GoldAfica).ToString();
            txtDiamondAfricaValue.Text = save.ReadInt32(block + FixedOffsets.DiamondAfrica).ToString();
            txtLegendaryAfricaValue.Text = save.ReadInt32(block + FixedOffsets.LegendaryAfrica).ToString();
            txtGoldJapanValue.Text = save.ReadInt32(block + FixedOffsets.GoldJapan).ToString();
            txtDiamondJapanValue.Text = save.ReadInt32(block + FixedOffsets.DiamondJapan).ToString();
            txtLegendaryJapanValue.Text = save.ReadInt32(block + FixedOffsets.LegendaryJapan).ToString();

            log.LogRead("Money", save.Data, block + FixedOffsets.Money);
            log.LogRead("Gold", save.Data, block + FixedOffsets.Gold);
            log.LogRead("Diamond", save.Data, block + FixedOffsets.Diamond);
            log.LogRead("Legendary", save.Data, block + FixedOffsets.Legendary);
            log.LogRead("Gold Norway", save.Data, block + FixedOffsets.GoldNorway);
            log.LogRead("Diamond Norway", save.Data, block + FixedOffsets.DiamondNorway);
            log.LogRead("Legendary Norway", save.Data, block + FixedOffsets.LegendaryNorway);
            log.LogRead("Gold Spain", save.Data, block + FixedOffsets.GoldSpain);
            log.LogRead("Diamond Spain", save.Data, block + FixedOffsets.DiamondSpain);
            log.LogRead("Legendary Spain", save.Data, block + FixedOffsets.legendarySpain);
            log.LogRead("Gold Africa", save.Data, block + FixedOffsets.GoldAfica);
            log.LogRead("Diamond Africa", save.Data, block + FixedOffsets.DiamondAfrica);
            log.LogRead("Legendary Africa", save.Data, block + FixedOffsets.LegendaryAfrica);
            log.LogRead("Gold Japan", save.Data, block + FixedOffsets.GoldJapan);
            log.LogRead("Diamond Japan", save.Data, block + FixedOffsets.DiamondJapan);
            log.LogRead("Legendary Japan", save.Data, block + FixedOffsets.LegendaryJapan);

            
            txtExpValue.Text = save.ReadInt32(FixedOffsets.Exp).ToString();
            txtRepUS.Text = save.ReadInt32(FixedOffsets.RepUS).ToString();
            txtRepNorway.Text = save.ReadInt32(FixedOffsets.RepNorway).ToString();
            txtRepSpain.Text = save.ReadInt32(FixedOffsets.RepSpain).ToString();
            txtRepAfrica.Text = save.ReadInt32(FixedOffsets.RepAfrica).ToString();
            txtRepJapan.Text = save.ReadInt32(FixedOffsets.RepJapan).ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (save == null)
            {
                log.Log("ERROR: No save file loaded.");
                return;
            }

            string backup = BackupManager.CreateBackup(save.Path);
            log.Log($"Backup created: {backup}");

            int block = PatternScanner.Find(save.Data, FullPattern);

            if (block == -1)
            {
                log.Log("ERROR: Pattern not found. Write aborted.");
                return;
            }
            
            save.WriteInt32(block + FixedOffsets.Gold, int.Parse(txtGoldValue.Text));
            save.WriteInt32(block + FixedOffsets.Diamond, int.Parse(txtDiamondValue.Text));
            save.WriteInt32(block + FixedOffsets.Legendary, int.Parse(txtLegendaryValue.Text));
            save.WriteInt32(block + FixedOffsets.GoldNorway, int.Parse(txtGoldNorwayValue.Text));
            save.WriteInt32(block + FixedOffsets.DiamondNorway, int.Parse(txtDiamondNorwayValue.Text));
            save.WriteInt32(block + FixedOffsets.LegendaryNorway, int.Parse(txtLegendaryNorwayValue.Text));
            save.WriteInt32(block + FixedOffsets.GoldSpain, int.Parse(txtGoldSpainValue.Text));
            save.WriteInt32(block + FixedOffsets.DiamondSpain, int.Parse(txtDiamondSpainValue.Text));
            save.WriteInt32(block + FixedOffsets.legendarySpain, int.Parse(txtLegendarySpainValue.Text));
            save.WriteInt32(block + FixedOffsets.GoldAfica, int.Parse(txtGoldAfricaValue.Text));
            save.WriteInt32(block + FixedOffsets.DiamondAfrica, int.Parse(txtDiamondAfricaValue.Text));
            save.WriteInt32(block + FixedOffsets.LegendaryAfrica, int.Parse(txtLegendaryAfricaValue.Text));
            save.WriteInt32(block + FixedOffsets.GoldJapan, int.Parse(txtGoldJapanValue.Text));
            save.WriteInt32(block + FixedOffsets.DiamondJapan, int.Parse(txtDiamondJapanValue.Text));
            save.WriteInt32(block + FixedOffsets.LegendaryJapan, int.Parse(txtLegendaryJapanValue.Text));


            if (chkMoneyWrite.Checked)
            //   save.WriteInt32(FixedOffsets.Money, int.Parse(txtMoneyValue.Text));
            save.WriteInt32(block + FixedOffsets.Money, int.Parse(txtMoneyValue.Text));

            if (chkExpWrite.Checked)
                save.WriteInt32(FixedOffsets.Exp, int.Parse(txtExpValue.Text));

            if (chkRepWrite.Checked)
            save.WriteInt32(FixedOffsets.RepUS, int.Parse(txtRepUS.Text));
            save.WriteInt32(FixedOffsets.RepNorway, int.Parse(txtRepNorway.Text));
            save.WriteInt32(FixedOffsets.RepSpain, int.Parse(txtRepSpain.Text));
            save.WriteInt32(FixedOffsets.RepAfrica, int.Parse(txtRepAfrica.Text));
            save.WriteInt32(FixedOffsets.RepJapan, int.Parse(txtRepJapan.Text));

            save.Save();
            log.Log("Write complete.");
        }

        private void rtbDebugButton_Click(object sender, EventArgs e)
        {
            rtbDebug.Clear();
        }
    }

}
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Romance_City_Planner.Classes;

namespace Romance_City_Planner
{
    public partial class Form1 : Form
    {
        static CityProfile selectedCity;
        static Mission selectedMission;
        bool monthPrimed = true;
        public Form1()
        {
            InitializeComponent();
            CityProfile.initalize();
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool valid = false;
            string processedName = listBoxCities.SelectedItem.ToString().Split(' ')[1];
            foreach(CityProfile city in CityProfile.cityProfiles)
            {
                if(city.name == processedName)
                {
                    selectedCity = city;
                    valid = true;
                }
            }
            if(valid)
            {
                refreshCity();
            }

        }

        private void refreshCity()
        {
            if(selectedCity != null)
            {
                textBoxName.Text = selectedCity.name;
                textBoxPrefect.Text = selectedCity.prefect;
                textBoxRuler.Text = selectedCity.owner;
                textBoxBows.Text = selectedCity.bows.ToString();
                textBoxBreastplates.Text = selectedCity.breastPlates.ToString();
                textBoxCaravans.Text = selectedCity.caravans.ToString();
                textBoxChain.Text = selectedCity.chainMails.ToString();
                textBoxETroops.Text = selectedCity.eliteTroops.ToString();
                textBoxFood.Text = selectedCity.food.ToString();
                textBoxGold.Text = selectedCity.gold.ToString();
                textBoxHarvest.Text = selectedCity.harvest.ToString();
                textBoxHorses.Text = selectedCity.horses.ToString();
                textBoxLeather.Text = selectedCity.leatherArmours.ToString();
                textBoxOrder.Text = selectedCity.order.ToString();
                textBoxPop.Text = selectedCity.population.ToString();
                textBoxShields.Text = selectedCity.shields.ToString();
                textBoxSpears.Text = selectedCity.spears.ToString();
                textBoxSwords.Text = selectedCity.swords.ToString();
                textBoxTroops.Text = selectedCity.troops.ToString();
                textBoxWealth.Text = selectedCity.wealth.ToString();
                MissionList.Items.Clear();
                foreach(Mission mission in selectedCity.presentMissions)
                {
                    MissionList.Items.Add(mission.missionID.ToString() + ". " + mission.name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSwords_Click(object sender, EventArgs e)
        {
            if(selectedCity != null)
            {
                selectedCity.purchaseSwords();
                refreshCity();
            }
        }

        private void buttonTaxes_Click(object sender, EventArgs e)
        {
            if(selectedCity != null)
            {
                selectedCity.adjustGold();
                refreshCity();
            }
        }

        private void buttonEat_Click(object sender, EventArgs e)
        {
            if(selectedCity != null)
            {
                selectedCity.adjustFood();
                refreshCity();
            }
        }

        private void buttonGenvans_Click(object sender, EventArgs e)
        {
            if(selectedCity != null)
            {
                selectedCity.generateCaravans();
                refreshCity();
            }
        }

        private void buttonGenvest_Click(object sender, EventArgs e)
        {
            if(selectedCity != null)
            {
                selectedCity.generateHarvest();
                refreshCity();
            }
        }

        private void buttonPopGrowth_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.populationGrowth();
                refreshCity();
            }
        }

        private void buttonTroops_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.raiseTroops();
                refreshCity();
            }
        }

        private void buttonSpears_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseSpears();
                refreshCity();
            }
        }

        private void buttonBows_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseBows();
                refreshCity();
            }
        }

        private void buttonHorses_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseHorses();
                refreshCity();
            }
        }

        private void buttonLeather_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseLeather();
                refreshCity();
            }
        }

        private void buttonChain_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseChainMail();
                refreshCity();
            }
        }

        private void buttonBreastplates_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseBreastplate();
                refreshCity();
            }
        }

        private void buttonShields_Click(object sender, EventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.purchaseShields();
                refreshCity();
            }
        }

        private void buttonRunMonth_Click(object sender, EventArgs e)
        {
            if(monthPrimed == true)
            {
                foreach (CityProfile city in CityProfile.cityProfiles)
                {
                    city.runMonth();
                }
                monthPrimed = false;
                labelPriming.Text = "Month Not Primed";
                if(selectedCity != null)
                {
                    refreshCity();
                }
            }

        }

        private void buttonPrimeMonth_Click(object sender, EventArgs e)
        {
            monthPrimed = true;
            labelPriming.Text = "Month Primed";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavedState save = new SavedState();
            save.cityProfiles = CityProfile.cityProfiles;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Profiles files (*.Prf)|*.Prf|All Files (*.*)|(*.*)";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteToBinaryFile<SavedState>(saveFileDialog1.FileName, save);
            }
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavedState save;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Profiles files (*.Prf)|*.Prf|All Files (*.*)|(*.*)";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                save = ReadFromBinaryFile<SavedState>(filePath);
                CityProfile.cityProfiles = save.cityProfiles;
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        private void MissionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool valid = false;
            foreach (Mission mission in selectedCity.presentMissions)
            {
                string missionID = MissionList.SelectedItem.ToString().Split('.')[0];
                if (mission.missionID.ToString() == missionID)
                {
                    selectedMission = mission;
                    valid = true;
                }
            }
            if (valid)
            {
                textBoxMissionName.Text = selectedMission.name;
                textBoxEnemyType.Text = selectedMission.enemyType;
                textBoxComplication.Text = selectedMission.complication;
                textBoxOverlevelled.Text = selectedMission.overLevelled.ToString();
            }
        }

        private void MissionGenButton_Click(object sender, EventArgs e)
        {
            selectedCity.generateMission();
            refreshCity();
        }

        private void buttonRemoveMission_Click(object sender, EventArgs e)
        {
            selectedMission.location.presentMissions.Remove(selectedMission);
            selectedMission = null;
            refreshCity();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            selectedCity.gold = double.Parse(textBoxGold.Text);
            selectedCity.food = int.Parse(textBoxFood.Text);
            selectedCity.bows = int.Parse(textBoxBows.Text);
            selectedCity.breastPlates = int.Parse(textBoxBreastplates.Text);
            selectedCity.caravans = int.Parse(textBoxCaravans.Text);
            selectedCity.chainMails = int.Parse(textBoxChain.Text);
            selectedCity.eliteTroops = int.Parse(textBoxETroops.Text);
            selectedCity.harvest = int.Parse(textBoxHarvest.Text);
            selectedCity.horses = int.Parse(textBoxHorses.Text);
            selectedCity.leatherArmours = int.Parse(textBoxLeather.Text);
            selectedCity.order = int.Parse(textBoxOrder.Text);
            selectedCity.population = int.Parse(textBoxPop.Text);
            selectedCity.shields = int.Parse(textBoxShields.Text);
            selectedCity.spears = int.Parse(textBoxSpears.Text);
            selectedCity.swords = int.Parse(textBoxSwords.Text);
            selectedCity.troops = int.Parse(textBoxTroops.Text);
            selectedCity.wealth = int.Parse(textBoxWealth.Text);
        }
    }
}

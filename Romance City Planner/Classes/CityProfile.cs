using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romance_City_Planner.Classes
{
    [Serializable]
    class CityProfile
    {
        public static List<CityProfile> cityProfiles;

        public string name;
        public string owner;
        public string prefect;

        public int population;
        public int troops;
        public int eliteTroops;
        public double gold;
        public int food;
        public int wealth;
        public int caravans;
        public int harvest;
        public int order;

        public int spears;
        public int swords;
        public int bows;
        public int horses;
        public int leatherArmours;
        public int chainMails;
        public int breastPlates;
        public int shields;

        Random rand = new Random();

        public List<Mission> presentMissions = new List<Mission>();

        public static void initalize()
        {
            cityProfiles = new List<CityProfile>();
            cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            cityProfiles.Add(new CityProfile("Jiayugyi", "Kwan Jie", "Kwan Jie", 1600000, 0, 5000, 250, 1000000, 2, 0, 0, 5, 500, 5000, 500, 5000, 0, 500, 500, 5000));
            cityProfiles.Add(new CityProfile("Weifei", "Pan Wu", "Pan Wu", 1900000, 10000, 5000, 1000, 1000000, 2, 0, 0, 3, 5000, 10000, 5000, 10000, 5000, 0, 10000, 5000));
            cityProfiles.Add(new CityProfile("Hijinch", "Pan Lin", "Pan Lin", 2200000, 10000, 10000, 1500, 1000000, 3, 0, 0, 4, 5000, 10000, 10000, 10000, 10000, 5000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Hanyi", "Sun Guanting", "Sun Guanting", 2600000, 30000, 15000, 2500, 1000000, 2, 0, 0, 5, 25000, 5000, 25000, 5000, 5000, 50000, 10000, 0));

            cityProfiles.Add(new CityProfile("Heze", "Sun Guanting", "Sun Guanting", 1200000, 10000, 0, 1500, 1000000, 3, 0, 0, 4, 10000, 0, 5000, 0, 0, 15000, 5000, 0));
            cityProfiles.Add(new CityProfile("Xingyi", "Sun Shi", "Sun Shi", 2800000, 30000, 10000, 3000, 1000000, 3, 0, 0, 3, 20000, 5000, 10000, 5000, 10000, 20000, 15000, 5000));
            cityProfiles.Add(new CityProfile("Shanyi", "Lee Bo", "Lee Bo", 1300000, 25000, 10000, 2500, 1000000, 1, 0, 0, 5, 10000, 10000, 20000, 10000, 5000, 30000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Bozhou", "Zhang Guanyu", "Zhang Guanyu", 1000000, 5000, 0, 5000, 1000000, 2, 0, 0, 5, 5000, 0, 5000, 0, 0, 5000, 0, 5000));
            cityProfiles.Add(new CityProfile("Harbo", "Zhang Guanyu", "Zhang An", 1700000, 10000, 5000, 3500, 1000000, 3, 0, 0, 5, 1000, 5000, 5000, 5000, 0, 10000, 5000, 5000));

            cityProfiles.Add(new CityProfile("Jiaxuanch", "Zhang Yong", "Zhang Yong", 1100000, 5000, 5000, 1500, 1000000, 2, 0, 0, 4, 5000, 5000, 5000, 5000, 10000, 0, 10000, 5000));
            cityProfiles.Add(new CityProfile("Bengbei", "Mu Chan", "Chan Triplets", 1400000, 15000, 5000, 5000, 1000000, 3, 0, 0, 4, 5000, 10000, 10000, 10000, 0, 10000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Changyi", "Mu Chan", "Mu Chan", 2000000, 25000, 10000, 5000, 1000000, 3, 0, 0, 5, 5000, 15000, 15000, 15000, 0, 20000, 10000, 10000));
            cityProfiles.Add(new CityProfile("Xiangfei", "Liao Wu", "Liao Bo", 1800000, 45000, 10000, 500, 1000000, 2, 0, 0, 3, 55000, 0, 10000, 0, 0, 60000, 15000, 0));
            cityProfiles.Add(new CityProfile("Charbo", "Liao Wu", "Liao Wu", 2800000, 50000, 10000, 1500, 1000000, 3, 0, 0, 4, 70000, 0, 15000, 0, 5000, 70000, 20000, 5000));

            cityProfiles.Add(new CityProfile("Hanjing", "Liao Wu", "Liao Yin", 1200000, 30000, 5000, 500, 1000000, 1, 0, 0, 3, 40000, 0, 5000, 0, 10000, 40000, 5000, 0));
            cityProfiles.Add(new CityProfile("Putou", "Liao Wu", "Liao Ju", 1300000, 10000, 5000, 1500, 1000000, 3, 0, 0, 3, 20000, 0, 5000, 0, 0, 20000, 0, 0));
            cityProfiles.Add(new CityProfile("Anjing", "Liao Wu", "Liao Wen", 1700000, 20000, 5000, 500, 1000000, 3, 0, 0, 3, 30000, 0, 5000, 0, 10000, 30000, 0, 0));
            cityProfiles.Add(new CityProfile("Zhuanyi", "Zheng Zhou", "Zheng Zhou", 2200000, 10000, 5000, 1500, 1000000, 3, 0, 0, 4, 10000, 10000, 10000, 10000, 10000, 15000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Hengzhou", "Sun Tao", "Sun Tao", 2600000, 25000, 20000, 3000, 1000000, 3, 0, 0, 5, 30000, 20000, 20000, 20000, 20000, 30000, 10000, 10000));

            cityProfiles.Add(new CityProfile("Beijin", "Fan Heng", "Fan Heng", 1000000, 10000, 5000, 2500, 1000000, 3, 0, 0, 5, 20000, 5000, 5000, 5000, 0, 5000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Nanchou", "Zheng Zan", "Zheng Zan", 1700000, 30000, 15000, 1500, 1000000, 3, 0, 0, 4, 40000, 10000, 40000, 10000, 5000, 30000, 30000, 10000));
            cityProfiles.Add(new CityProfile("Sanming", "Kuang Xiu", "Kuang Xiu", 1600000, 10000, 20000, 500, 1000000, 1, 0, 0, 5, 10000, 10000, 30000, 10000, 0, 40000, 10000, 0));
            cityProfiles.Add(new CityProfile("Haohou", "Kuang Yijun", "Kuang Yijun", 2100000, 20000, 25000, 500, 1000000, 1, 0, 0, 5, 10000, 10000, 50000, 10000, 0, 50000, 10000, 5000));
            cityProfiles.Add(new CityProfile("Yinin", "Kwok Jiahao", "Kwok Jiahao", 1000000, 20000, 15000, 1500, 1000000, 1, 0, 0, 3, 5000, 40000, 20000, 40000, 40000, 20000, 20000, 5000));

            cityProfiles.Add(new CityProfile("Houshou", "Wen Heng", "Wen Heng", 1100000, 20000, 10000, 500, 1000000, 1, 0, 0, 2, 0, 30000, 10000, 30000, 35000, 30000, 5000, 0));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));

            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
            //cityProfiles.Add(new CityProfile("Qingyi", "Lau Zheng", "Lau Zheng", 3100000, 100000, 100000, 500, 1000000, 3, 0, 0, 4, 50000, 50000, 50000, 50000, 50000, 50000, 50000, 50000));
        }

        public CityProfile(string name, string owner, string prefect, int population, int troops, int eliteTroops, int gold, int food, int wealth, int caravans, int harvest, int order, int spears, int swords, int bows, int shields, int horses, int leather, int mail, int breastPlates)
        {
            this.name = name;
            this.owner = owner;
            this.prefect = prefect;
            this.population = population;
            this.troops = troops;
            this.eliteTroops = eliteTroops;
            this.gold = gold;
            this.food = food;
            this.wealth = wealth;
            this.caravans = caravans;
            this.harvest = harvest;
            this.order = order;
            this.spears = spears;
            this.swords = swords;
            this.shields = shields;
            this.bows = bows;
            this.horses = horses;
            leatherArmours = leather;
            this.breastPlates = breastPlates;
            chainMails = mail;
        }

        public void runMonth()
        {
            generateCaravans();
            generateHarvest();
            adjustGold();
            populationGrowth();
            adjustFood();
            generateMission();

        }

        public void populationGrowth()
        {
            double x = (Convert.ToDouble(order) + Convert.ToDouble(wealth)) / 1000;
            double populationGrowth = population * x;
            population += Convert.ToInt32(populationGrowth);

        }

        public void raiseTroops()
        {
            if(gold >= 640 && population >= 1000)
            {
                gold -= 640;
                troops += 1000;
                population -= 1000;
            }
        }

        public void adjustGold()
        {
            gold += population * 0.02;
            gold -= troops * 0.32;
            gold -= eliteTroops * 0.48;
            if(wealth == 1)
            {
                gold -= population * 0.005;
            }
            else if(wealth == 3)
            {
                gold += population * 0.005;
            }
            int x = 0;
            while(x != caravans)
            {
                gold += rand.Next(100, 250);
                x += 1;
            }
        }

        public void generateCaravans()
        {
            int tempCount = 0;
            int tempPop = population;
            while (tempPop >= 0)
            {
                tempPop -= 250000;
                tempCount += 1;
            }
            switch(wealth)
            {
                case 1:
                    tempCount -= rand.Next(1,3);
                    break;
                case 2:
                    break;
                case 3:
                    tempCount += rand.Next(1, 3);
                    break;
            }
            switch(order)
            {
                case 1:
                    tempCount -= rand.Next(3, 5);
                    break;
                case 2:
                    tempCount -= rand.Next(2, 3);
                    break;
                case 3:
                    tempCount -= rand.Next(1, 2);
                    break;
                case 4:
                    break;
                case 5:
                    tempCount += rand.Next(1, 3);
                    break;
            }
            tempCount += rand.Next(-1, 3);
            if(tempCount < 0)
            {
                tempCount = 0;
            }
            caravans = tempCount;
        }

        public void generateHarvest()
        {
            harvest = population * (rand.Next(8, 16) + order);
        }

        public void adjustFood()
        {
            food += harvest;
            food -= (population + troops + eliteTroops) * 10;
        }

        public void purchaseSwords()
        {
            if(gold >= 200)
            {
                gold -= 200;
                swords += 1000;
            }
        }

        public void purchaseSpears()
        {
            if (gold >= 60)
            {
                gold -= 60;
                spears += 1000;
            }
        }

        public void purchaseBows()
        {
            if (gold >= 150)
            {
                gold -= 150;
                bows += 1000;
            }
        }

        public void purchaseHorses()
        {
            if (gold >= 1500)
            {
                gold -= 1500;
                horses += 1000;
            }
        }

        public void purchaseLeather()
        {
            if (gold >= 200)
            {
                gold -= 200;
                leatherArmours += 1000;
            }
        }

        public void purchaseChainMail()
        {
            if (gold >= 300)
            {
                gold -= 300;
                chainMails += 1000;
            }
        }

        public void purchaseBreastplate()
        {
            if (gold >= 600)
            {
                gold -= 600;
                breastPlates += 1000;
            }
        }

        public void purchaseShields()
        {
            if (gold >= 200)
            {
                gold -= 200;
                shields += 1000;
            }
        }

        public void generateMission()
        {
                int MissionCount = 7 - order;
                int x = 0;
                List<Mission> toBeRemoved = new List<Mission>();
                foreach (Mission mission in presentMissions)
                {
                    int y = rand.Next(1, 10);
                    if (y <= order)
                    {
                        toBeRemoved.Add(mission);
                    }
                }
                foreach (Mission mission in toBeRemoved)
                {
                    presentMissions.Remove(mission);
                }
                while (x != MissionCount)
                {
                    presentMissions.Add(new Mission(this, rand));
                    x += 1;
                }
        }

    }
}

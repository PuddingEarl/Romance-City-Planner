using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romance_City_Planner.Classes
{
    [Serializable]
    class Mission
    {
        public static int missionCount = 0;
        public int missionType;
        public int level;
        public int variable1;
        public int variable2;
        public int complicationID;
        public string name;
        public string enemyType;
        public string complication;
        public int overLevelled;
        public int goldReward;
        public CityProfile location;
        public int missionID;

        public Mission(CityProfile location, Random rand)
        {
            this.location = location;
            missionID = missionCount;
            missionCount += 1;
            missionType = rand.Next(1, 8);
            enemyType = "";
            switch (missionType)
            {
                case 1:
                    variable1 = rand.Next(1, 10);
                    switch(variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                            name = "Guard the Merchants";
                            variable2 = rand.Next(1, 10);
                            switch(variable2)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    enemyType = "Wolves";
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                    enemyType = "Bandits";
                                    break;
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                        case 4:
                        case 5:
                        case 6:
                            name = "Guard the Officials";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                    enemyType = "Wolves";
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    enemyType = "Bandits";
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                    enemyType = "Enemy Family";
                                    break;
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                        case 7:
                        case 8:
                            name = "Guard the Village";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    enemyType = "Wolves";
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                    enemyType = "Bandits";
                                    break;
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                        case 9:
                            name = "Guard the Officer";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                    enemyType = "Wolves";
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    enemyType = "Bandits";
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                        case 10:
                            name = "Guard the City";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                    enemyType = "Wolves";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                    enemyType = "Bandits";
                                    break;
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            name = "Escort the Caravan";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    enemyType = "Wolves";
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                    enemyType = "Bandits";
                                    break;
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                        case 7:
                        case 8:
                            name = "Escort the Official";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                    enemyType = "Wolves";
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    enemyType = "Bandits";
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                    enemyType = "Enemy Family";
                                    break;
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                        case 9:
                            name = "Escort the Important Figure";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                    enemyType = "Wolves";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    enemyType = "Bandits";
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    enemyType = "Enemy Family";
                                    break;
                                case 9:
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                        case 10:
                            name = "Escort the Officer";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                    enemyType = "Wolves";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    enemyType = "Bandits";
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    enemyType = "Enemy Family";
                                    break;
                                case 9:
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                            name = "Exterminate the Wolves";
                            enemyType = "Wolves";
                            break;
                        case 4:
                        case 5:
                        case 6:
                            name = "Exterminate the Tigers";
                            enemyType = "Tigers";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            name = "Exterminate the Bandits";
                            enemyType = "Bandits";
                            break;
                        case 10:
                            name = "Exterminate the Vagabond Unit";
                            enemyType = "Vagabonds";
                            break;
                    }
                    break;
                case 4:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                            name = "Assassinate the Merchant";
                            break;
                        case 4:
                        case 5:
                            name = "Assassinate the Official";
                            break;
                        case 6:
                        case 7:
                            name = "Assassinate the Captain";
                            break;
                        case 8:
                        case 9:
                            name = "Assassinate the Officer";
                            break;
                        case 10:
                            name = "Assassinate the Important Figure";
                            break;
                    }
                    break;
                case 5:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                            name = "Infiltrate the Merchant's House";
                            break;
                        case 3:
                        case 4:
                            name = "Infiltrate the Official's House";
                            break;
                        case 5:
                        case 6:
                            name = "Infiltrate the City";
                            break;
                        case 7:
                        case 8:
                            name = "Infiltrate the Armory";
                            break;
                        case 9:
                        case 10:
                            name = "Infiltrate the Manor";
                            break;
                    }
                    break;
                case 6:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            name = "Rescue the Caravan";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    enemyType = "Wolves";
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                    enemyType = "Bandits";
                                    break;
                                case 8:
                                case 9:
                                case 10:
                                    enemyType = "Enemy Family";
                                    break;
                            }
                            break;
                        case 7:
                        case 8:
                            name = "Rescue the Official";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                case 2:
                                    enemyType = "Wolves";
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    enemyType = "Bandits";
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                    enemyType = "Enemy Family";
                                    break;
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                        case 9:
                            name = "Rescue the Important Figure";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                    enemyType = "Wolves";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    enemyType = "Bandits";
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    enemyType = "Enemy Family";
                                    break;
                                case 9:
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                        case 10:
                            name = "Rescue the Officer";
                            variable2 = rand.Next(1, 10);
                            switch (variable2)
                            {
                                case 1:
                                    enemyType = "Wolves";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    enemyType = "Bandits";
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    enemyType = "Enemy Family";
                                    break;
                                case 9:
                                case 10:
                                    enemyType = "Assassin";
                                    break;
                            }
                            break;
                    }
                    break;
                case 7:
                    variable1 = rand.Next(1, 10);
                    switch (variable1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            name = "Raid the Caravan";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            name = "Raid the Village";
                            break;
                        case 9:
                            name = "Raid the Fort";
                            break;
                        case 10:
                            name = "Raid the City";
                            break;
                    }
                    break;
                case 8:
                    level = 0;
                    name = "Custom Mission";
                    goldReward = 0;
                    break;
            }
            switch(enemyType)
            {
                case "Wolves":
                    int x = rand.Next(1, 100);
                    if(x >= 96)
                    {
                        complicationID = rand.Next(1, 2);
                        if(complicationID == 1)
                        {
                            complication = "Dire Wolf Present";
                        }
                        else
                        {
                            complication = "Druid Leader Present";
                        }
                        int y = rand.Next(1, 100);
                        if(y >= 96)
                        {
                            overLevelled = 1;
                        }
                        else
                        {
                            overLevelled = 0;
                        }
                    }
                    break;
                case "Tigers":
                    x = rand.Next(1, 100);
                    if (x >= 96)
                    {
                        complicationID = rand.Next(1, 2);
                        if (complicationID == 1)
                        {
                            complication = "Dire Wolf Present";
                        }
                        else
                        {
                            complication = "Druid Leader Present";
                        }
                        int y = rand.Next(1, 100);
                        if (y >= 96)
                        {
                            overLevelled = 1;
                        }
                        else if(y <= 25)
                        {
                            overLevelled = -1;
                        }
                        else
                        {
                            overLevelled = 0;
                        }
                    }
                    break;
                case "Bandits":
                    x = rand.Next(1, 100);
                    if (x >= 91)
                    {
                        complicationID = rand.Next(1, 10);
                        switch(complicationID)
                        {
                            case 1:
                            case 2:
                                complication = "Bandit Patrol";
                                break;
                            case 3:
                            case 4:
                                complication = "Bandit Chief Present";
                                break;
                            case 5:
                            case 6:
                                complication = "Two Chiefs Present";
                                break;
                            case 7:
                            case 8:
                            case 9:
                                complication = "Captive Present";
                                break;
                            case 10:
                                complication = "Bandits All Elite";
                                break;
                        }
                        int y = rand.Next(1, 100);
                        if (y >= 99)
                        {
                            overLevelled = 1;
                        }
                        else if(y <= 10)
                        {
                            overLevelled = -1;
                        }
                        else
                        {
                            overLevelled = 0;
                        }
                    }
                    break;
            }

        }
    }
}

namespace TheSlum.GameEngine
{
    using System.Linq;

    public class AdvancedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            switch (inputParams[1])
            {
                case "mage":
                    Character newMage = new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue);
                    this.characterList.Add(newMage);
                    break;
                case "healer":
                    Character newHealer = new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue);
                    this.characterList.Add(newHealer);
                    break;
                case "warrior":
                    Character newWarrior = new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), inputParams[5] == "Red" ? Team.Red : Team.Blue);
                    this.characterList.Add(newWarrior);
                    break;
                default:
                    break;
            }
        }

        protected override void AddItem(string[] inputParams)
        {
            Character character;

            switch (inputParams[2])
            {
                case "injection":
                    var injection = new Injection(inputParams[3]);
                    character = this.characterList.First(c => c.Id == inputParams[1]);
                    character.AddToInventory(injection);
                    break;
                case "pill":
                    var pill = new Pill(inputParams[3]);
                    character = this.characterList.First(c => c.Id == inputParams[1]);
                    character.AddToInventory(pill);
                    break;
                case "axe":
                    var axe = new Axe(inputParams[3]);
                    character = this.characterList.First(c => c.Id == inputParams[1]);
                    character.AddToInventory(axe);
                    break;
                case "shield":
                    var shield = new Shield(inputParams[3]);
                    character = this.characterList.First(c => c.Id == inputParams[1]);
                    character.AddToInventory(shield);
                    break;
                default:
                    break;
            }
        }
    }
}

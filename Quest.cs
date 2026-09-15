
public enum QuestStatus
{
    pending = 0,
    accepted = 1,
    declined = 2,
    finished = 3
}

public class Quest
{
    public int ID;

    public string Description;

    public string Dialogue;

    public int RelevantLocationID;
    
    public Monster TargetMonster;
    public int MonsterCount;
    public int CurrentMonstersKilled;
    public string RewardMessage;
    public int Reward;

    public QuestStatus status;



    public Quest(int id, string description, string dialogue, int targetLocation, Monster targetMonster, int monsterCount, string rewardMessage, int reward)
    {
        ID = id;
        Description = description;
        Dialogue = dialogue;
        RelevantLocationID = targetLocation;
        status = QuestStatus.pending;
        TargetMonster = targetMonster;
        MonsterCount = monsterCount;
        CurrentMonstersKilled = 0;
        RewardMessage = rewardMessage;
        Reward = reward;
    }


    public int AcceptOrDenyQuest()
    {
        Console.WriteLine(Dialogue);
        Console.WriteLine($"{World.RED}Do u wish to accept this quest? {World.BOLD}{Description}{World.RESET}");
        Console.WriteLine($"{World.RESET}{World.DIM}({World.RESET}{World.GREEN}Y{World.RESET}{World.DIM}/{World.RESET}{World.RED}N{World.RESET}{World.DIM}){World.RESET}");
        string answer = World.ChooseOption("y", "n", "Please accept or deny a quest");
        if (answer == "y")
            status = QuestStatus.accepted;
        else if (answer == "n")
            status = QuestStatus.declined;
        return (int)status;
    }

    public void FinishQuest()
    {
        Console.WriteLine(RewardMessage);
        Program.Player.Gold += Reward;
        Program.Player.CurrentQuest = null;
        Console.WriteLine($"{World.YELLOW}+{Reward} Gold");
    }
}
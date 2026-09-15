
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

    public string name;

    public string description;

    public int RelevantLocationID;

    public QuestStatus status;



    public Quest(int id, string name, string description, int targetLocation)
    {
        this.ID = id;
        this.name = name;
        this.description = description;
        RelevantLocationID = targetLocation;
        status = QuestStatus.pending;
    }


    public int AcceptOrDenyQuest()
    {
        Console.WriteLine(description);
        Console.WriteLine($"Do u wish to accept this quest: {name}?");
        Console.WriteLine("Y/N");


        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            status = QuestStatus.accepted;
            return (int)status;
        }

        else if (answer == "n")
        {
            status = QuestStatus.declined;
            return (int)status;
        }

        else
        {
            Console.WriteLine("please accept or deny a quest");
            return (int)QuestStatus.pending;
        }

    }



    public int FinishQuest()
    {
        Console.WriteLine("u have completed the quest!");
        
        status = QuestStatus.finished;

        return (int)QuestStatus.finished;

    }

}
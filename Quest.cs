
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

    public Location RelevantLocationId;

    public Quest(int id, string name, string description,  Location targetLocation)
    {
        this.ID = id;
        this.name = name;
        this.description = description;
        RelevantLocationId = targetLocation;
    }


    public int AcceptOrDenyQuest()
    {
        Console.WriteLine(description);
        Console.WriteLine($"Do u wish to accept this quest: {name}?");
        Console.WriteLine("Y/N");


        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            return (int)QuestStatus.accepted;
        }

        else if (answer == "n")
        {
            return (int)QuestStatus.declined;
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
        return (int)QuestStatus.finished;

    }

}
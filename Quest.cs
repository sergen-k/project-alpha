public class Quest
{
    public int ID;

    public string name;

    public string description;

    public enum quest_status
    {
        pending,
        accepted,
        declined,
        finished
    } 

    public quest_status status;

    public Quest(int id,string name, string description)
    {
        this.ID = id;
        this.name = name;
        this.description = description;
    }


    public quest_status AcceptOrDenyQuest()
    {
        Console.WriteLine("Do u wish to accept this quest");
        Console.WriteLine("Y/N");
        string answer = Console.ReadLine().ToLower();

         if (answer == "y")
        {
            return status = quest_status.accepted;
        }

        else if(answer == "n")
        {
            return status = quest_status.declined;
        }

        else
        {
              Console.WriteLine("please accept or deny a quest");
              return status = quest_status.pending;
        }

    }



    public quest_status FinishQuest()
    {
        Console.WriteLine("u have completed the quest!");
        return status = quest_status.finished;

    }
    
}
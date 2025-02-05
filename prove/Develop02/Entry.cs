public class Entry
{
    public string prompt;
    public string response;
    public string date;


    public Entry(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;


    }

    public string Display(){
        return $"{date} | {prompt} | {response}";
    }
}
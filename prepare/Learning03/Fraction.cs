public class Fraction
{
    private int top_num;
    private int bot_num;
    
    public Fraction()
    {
        top_num = 1;
        bot_num = 1;

    }

    public Fraction(int top)
    {
        top_num = top;
        bot_num = 1;

    }

    public Fraction(int top, int bot)
    {
        top_num = top;
        bot_num = bot;

    }

    public string GetFractionString()
    {
        string text = ($"{top_num}/{bot_num}");
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top_num / (double)bot_num;
    }

    public int GetTop()
    {
        return top_num;
    }

    public void SetTop(int top)
    {
        top_num = top;
    }

    public int GetBot()
    {
        return bot_num;
    }

    public void SetBot(int bot)
    {
        bot_num = bot;
    }
}
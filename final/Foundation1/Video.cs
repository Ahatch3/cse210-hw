

using System.Linq.Expressions;
using System.Transactions;

public class Video{

    private string _author;

    private int _vidLength;

    private string _title;

    public List<Comment> comments1 = new List<Comment>();

    private Random random = new Random();

    string[] comment_section = {"Great video!",
    "Awesome content!",
    "Thanks for sharing!",
    "Very helpful.",
    "Love this!",
    "Keep up the good work.",
    "Subscribed!",
    "Interesting!",
    "This is amazing.",
    "I enjoyed this.",
    "LOL!",
    "That's hilarious!",
    "So true!",
    "I can relate.",
    "This made my day!",
    "That's awesome!",
    "I love your style.",
    "This is so good.",
    "I'm hooked!",
    "You're a genius!",
    "I learned a lot from this.",
    "This helped me so much.",
    "This is exactly what I needed.",
    "Thank you for clarifying that.",
    "I appreciate your perspective.",
    "This video is very informative.",
    "I agree with you.",
    "I had the same problem.",
    "This is very useful.",
    "I'm going to try this!"};

    string[] commenters = {
        "GamingNinja42",
    "MusicLover88",
    "TechGuru2000",
    "TravelVlogz",
    "CookingMaster101",
    "ArtisticSoul99",
    "ComedyCentralFan",
    "SportsAddict77",
    "BookwormReads",
    "FashionForward56",
    "ScienceExplorer123",
    "DIYProjects4U",
    "PetAdventures",
    "MovieBuffReviews",
    "HistoricalHappenings",
    "WildernessWanderer",
    "UrbanExploration",
    "RetroGamingVault",
    "ModernArtMuse",
    "GlobalCuisine",
    "FitnessFreak247",
    "MindfulMeditations",
    "AstrologyInsights",
    "CryptoCurrencyDaily",
    "SustainableLivingNow",
    "LanguageLearningHub",
    "ProductivityPointers",
    "PersonalFinanceTips"
    };



    public Video(string _author, int _vidLength, string _title){

        this._author = _author;
        this._vidLength = _vidLength;
        this._title = _title;
    }


    int loop = 0;

    public void Display(){

        while (loop != 3){

            loop += 1;

            Comment comment = new Comment(GetRandomCommenter(), GetRandomComment());

            comments1.Add(comment);
        }

        Console.WriteLine($"---YOUTUBE VIDEO---\n\nVideo Name: {_title}\nCreator: {_author}\nLength: {_vidLength} minutes");

        foreach (Comment com in comments1){
            com.CommentDisplay();
        }


    }

    public string GetRandomComment(){

        int randomIndex = random.Next(comment_section.Length);
        return comment_section[randomIndex]; 
    }
    public string GetRandomCommenter(){

        int randomIndex = random.Next(commenters.Length);
        return commenters[randomIndex]; 
    }
}